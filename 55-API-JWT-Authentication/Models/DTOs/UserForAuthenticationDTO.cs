using System.ComponentModel.DataAnnotations;

namespace _55_API_JWT_Authentication.Models.DTOs
{
    public class UserForAuthenticationDTO
    {
        [Required(ErrorMessage = "Username is requried!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is requried!")]
        public string? Password { get; set; }
    }
}
