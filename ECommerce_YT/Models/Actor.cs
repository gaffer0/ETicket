using System.ComponentModel.DataAnnotations;

namespace ECommerce_YT.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
        //relations
        public List<Actor_Movie> Actors_Movies { get; set; }


    }
}
