using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Opdracht1.Models
{
    public class Films
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public String Title { get; set; }

        [Required]
        [Display(Name = "Regiseur")]
        public string Regiseur { get; set; }

        [Required]
        [Display(Name = "Acteurs")]
        public string Acteurs { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Prijs")]
        public float Prijs { get; set; }

        [Required]
        [Display(Name = "Review")]
        public String Review { get; set; }

        [Required]
        [Display(Name = "AdultRating")]
        public bool AdultRating { get; set; }

        [Display(Name = "Poster")]
        public string Poster { get; set; }

        [Display(Name = "Rated")]
        public string Rated { get; set; }

        [Display(Name = "Runtime")]
        public string Runtime { get; set; }

        [Display(Name = "Plot")]
        public string Plot { get; set; }

        public bool visible { get; set; }

        public Films()
        {
            visible = true;
        }
    }
}
