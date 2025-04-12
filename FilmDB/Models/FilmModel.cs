using System.ComponentModel.DataAnnotations;

namespace FilmDB.Models
{
    public class FilmModel
    {
        public string ID { get; set; }
        [Required]
        public string Title { get; set; } 
        public int Year { get; set; }   
    }
}
