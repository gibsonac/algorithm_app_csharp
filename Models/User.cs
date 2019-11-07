using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace algo_csharp_proj.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "First name must be more than 2 characters!")]
        public string First_Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be more than 2 characters!")]
        public string Last_Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime Updated_At { get; set; } = DateTime.Now;
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string password_confirm { get; set; }
        public User()
        {
        }
    }
}
