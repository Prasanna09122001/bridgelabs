using FundooModel.User;
using FundooRepo.Context;
using FundooRepo.IRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NLogImplementation;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepo.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly UserDbContext context;
        public readonly IConfiguration configuration;
        public string key = "ankit@@sehrawat@@";
        NlogOperation log = new NlogOperation();
        public UserRepository(UserDbContext context, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.context = context;
        }

        public Task<int> RegisterUser(Register register)
        {
            var password = EncryptPassword(register.Password);
            register.Password = password;
            this.context.Register.Add(register);
            var result = this.context.SaveChangesAsync();
            log.LogInfo("Registraion is Done Successfully");
            return result;
        }
        public string LoginUser(Login login)
        {
            try
            {
                var result = this.context.Register.Where(x => x.Email.Equals(login.Email)).FirstOrDefault();
                var decryptpassword = DecryptPassword(result.Password);
                if (result != null && decryptpassword.Equals(login.Password))
                {
                    var token = GenerateSecurity( result.Email, result.Id);
                    log.LogInfo("Login is Done Successfully");
                    return token;
                }
                log.LogWarn("Your Email or Password is wrong");
                return null;
            }
            catch (Exception Ex)
            {
                log.LogError(Ex.Message);
                throw;
            }
        }
        public Register ResetPassword(ResetPassword reset)
        {
            if (reset.NewPassword.Equals(reset.ConfirmPassword))
            {
                var input = this.context.Register.Where(x => x.Email.Equals(reset.Email)).FirstOrDefault();
                if (input != null)
                {
                    var password = EncryptPassword(reset.NewPassword);
                    input.Password = password;
                    this.context.Register.Update(input);
                    var result = this.context.SaveChangesAsync();
                    log.LogInfo("Reset Password Successful");
                    return input;
                }
                log.LogWarn("Enter the Values Correctly");
                return null;
            }
            log.LogWarn("Your Passwrod is not matched with Confirm Password");
            return null;
        }
        public string GenerateSecurity(string email, int userId)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var key1 = Encoding.ASCII.GetBytes(this.configuration[("JWT:Key")]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, email),
                    new Claim("Id",userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key1),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            return tokenhandler.WriteToken(token);
        }
        public string ForgetPassword(string Email)
        {
            try
            {
                var emailcheck = this.context.Register.FirstOrDefault(x => x.Email == Email);
                if (emailcheck != null)
                {
                    var token = GenerateSecurity(emailcheck.Email, emailcheck.Id);
                    MSMQ msmq = new MSMQ();
                    msmq.sendData2Queue(token,Email);
                    log.LogInfo("Message Send to the User Mail Succesfully");
                    return token;
                }
                else
                {
                    log.LogWarn("Your Mail is Incorrect. Please Verfiy it");
                    return null;
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                throw;
            }
        }
        //Password is critical resource --> we need to encrypt and save it in the db
        //At the time of login we need to decrypt and check.
        public string EncryptPassword(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
        public string DecryptPassword(string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new string(decoded_char);
            return decryptpwd;
        }
    }
}
