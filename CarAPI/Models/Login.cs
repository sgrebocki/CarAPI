using System.ComponentModel.DataAnnotations;

namespace CarAPI.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Błędna nazwa użytkownika")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Błędne hasło")]
        public string Password { get; set; }
    }
}
