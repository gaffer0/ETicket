using System.ComponentModel.DataAnnotations;

namespace ECommerce_YT.Models
{
    public class Producers
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
