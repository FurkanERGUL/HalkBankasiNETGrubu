using System.ComponentModel.DataAnnotations;

namespace _55_API_JWT_Authentication.Models.DTOs
{
    public class UserForRegisterDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required(ErrorMessage ="Username is requried!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is requried!")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
