using System.ComponentModel.DataAnnotations;

namespace ECommerce_YT.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }
        [Display(Name = "Cinema Logo")]
        public String Logo { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
