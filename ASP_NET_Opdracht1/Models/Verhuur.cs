using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Opdracht1.Models
{
    public class Verhuur
    {
        [Required]
        [Display(Name = "VerhuurId")]
        public int VerhuurId { get; set; }

        [Required]
        [Display(Name = "LidId")]
        public int LidId { get; set; }

        [Required]
        [Display(Name = "UitleenDatum")]
        public string UitleenDatum { get; set; }

        [Display(Name = "TerugDatum")]
        public string TerugDatum { get; set; }
        [Required]
        [Display(Name = "TotaalPrijs")]
        public float TotaalPrijs { get; set; }

        public bool visible { get; set; }

        public Verhuur()
        {
            visible = true;
        }
    }
}
