using System.ComponentModel.DataAnnotations;
using ECommerce_YT.Data.Enums;

namespace ECommerce_YT.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory movieCategory { get; set; }
        //relationships 
        public List<Actor_Movie> Actors_Movies { get; set; }
        public Cinema? Cinema { get; set; }
        public int CinemaId { get; set; }
        public int ProducerId { get; set; }
        public Producers Producer { get; set; }

    }
}
