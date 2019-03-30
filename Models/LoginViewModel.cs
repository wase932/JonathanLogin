using System;
using System.ComponentModel.DataAnnotations;

namespace JonathanLogin.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [MinLength(4)]
        [Required]
        public string Password { get; set; }
    }
}