using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarAPI.Models
{
    public class Car
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Marka")]
        [Required(ErrorMessage = "Podaj markę samochodu")]
        public string Brand { get; set; } = string.Empty;

        [Display(Name = "Model")]
        [Required(ErrorMessage = "Błędna wartość")]
        public string Model { get; set; } = string.Empty;

        [Display(Name = "Moc (w KM)")]
        [Required(ErrorMessage = "Błędna wartość")]
        public int Power { get; set; }

        [Display(Name = "Rok produkcji")]
        [Required(ErrorMessage = "Błędna wartość")]
        public int ProductionYear { get; set; }
    }
}
