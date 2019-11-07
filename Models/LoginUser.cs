using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace algo_csharp_proj.Models
{
    public class LoginUser
    {
        [Required]
        public string Email {get;set;}
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password {get;set;}
        public LoginUser()
        {
        }
    }
}
