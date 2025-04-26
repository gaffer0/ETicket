using System.ComponentModel.DataAnnotations;

namespace ECommerce_YT.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public String Logo { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
