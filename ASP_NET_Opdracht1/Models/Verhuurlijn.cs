using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Opdracht1.Models
{
    public class Verhuurlijn
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "VerhuurId")]
        public int VerhuurId { get; set; }

        [Required]
        [Display(Name = "FilmId")]
        public int FilmId { get; set; }

        [Required]
        [Display(Name = "Prijs")]
        public float Prijs { get; set; }

        [Required]
        [Display(Name = "UitleenDatum")]
        public string UitleenDatum { get; set; }

        [Display(Name = "TerugDatum")]
        public string TerugDatum { get; set; }

        public bool visible { get; set; }

        public Verhuurlijn()
        {
            visible = true;
        }
    }
}
