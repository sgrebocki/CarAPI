
using System.ComponentModel.DataAnnotations;

namespace CarAPI.Models
{
    public class Register
    {

        [Required(ErrorMessage = "Błędna nazwa użytkownika")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Zły adres email")]
        [Required(ErrorMessage = "Zły adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Błędne Hasło")]
        public string Password { get; set; } 
        
            
        
    }
}
