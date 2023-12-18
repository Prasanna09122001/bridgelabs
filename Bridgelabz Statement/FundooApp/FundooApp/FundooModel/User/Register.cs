using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FundooModel.User
{
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is Null")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Null")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone Number is Null")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is Null")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Null")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
