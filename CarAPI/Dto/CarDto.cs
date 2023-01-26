using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarAPI.Dto
{
    public class CarDto
    {

        [Display(Name = "Marka")]
        [Required(ErrorMessage = "Podaj markę samochodu")]
        public string Brand { get; set; } = string.Empty;

        [Display(Name = "Model")]
        [Required]
        public string Model { get; set; } = string.Empty;

        [Display(Name = "Moc (w KM)")]
        [Required]
        public int Power { get; set; }

        [Display(Name = "Rok produkcji")]
        [Required]
        public int ProductionYear { get; set; }

    }
}
