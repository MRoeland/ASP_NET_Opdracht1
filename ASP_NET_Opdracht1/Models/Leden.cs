using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Opdracht1.Models
{
    public class Leden
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public String Naam { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public string Adres { get; set; }

        [Required]
        [Display(Name = "TelNr")]
        public string TelNr { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public bool visible { get; set; }

        public Leden()
        {
            visible = true;
        }
    }
}
