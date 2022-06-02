using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string? UserName {get; set;}

        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Must be at least 4 characters long.")]
        public string? Password {get; set;}
    }
}