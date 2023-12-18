using FundooModel.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;
using FundooManager.IManager;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace FundooApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserManager userManager;
        public readonly IConfiguration configuration;
        public UserController(IUserManager userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> UserRegister(Register register)
        {
            try
            {
                var result = await this.userManager.RegisterUser(register);
                if (result == 1)
                {
                    return this.Ok(new { Status = true, Message = "User Registration Successful", data = register });
                }
                return this.BadRequest(new { Status = false, Message = "User Registration UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult UserLogin(Login login)
        {
            try
            {
                var result = this.userManager.LoginUser(login);
                if (result != null)
                {
                var tokenhandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenhandler.ReadJwtToken(result);
                var id = jwtToken.Claims.FirstOrDefault(c => c.Type == "Id");
                string Id = id.Value;
                
                    return this.Ok(new { Status = true, Message = "User Login Successful", data = result,Id=Id});
                }
                return this.BadRequest(new { Status = false, Message = "User Login UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [Authorize]
        [HttpPut]
        [Route("ResetPassword")]
        public ActionResult UserResultPassword(ResetPassword reset)
        {
            try
            {
                reset.Email = User.FindFirst(ClaimTypes.Email).Value.ToString();
                var result = this.userManager.ResetPassword(reset);
                if (result != null)
                {
                    return this.Ok(new { Status = true, Message = "Reset Password Successful", data = reset });
                }
                return this.BadRequest(new { Status = false, Message = "Reset Password UnSuccessful" });
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("ForgetPassword")]
        public ActionResult ForgetPassword(string email)
        {
            try
            {
                var resultLog = this.userManager.ForgetPassword(email);
                if (resultLog != null)
                {
                    return Ok(new { success = true, message = "Reset Email Send" });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Reset UnSuccessful" });
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }
       
    }
}
