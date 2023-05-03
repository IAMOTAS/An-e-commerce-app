using System.ComponentModel.DataAnnotations;

namespace An_e_commerce_app.Models
{
    public class Addtrack
    {
        [Key]
        public int Id { get; set; }
        public string? trackpictureURL { get; set; }

        public string? trackname { get; set; }

        public string? trackdescription { get; set; }
        public string? releasedate { get; set; }
        public string? trackid { get; set; }

        public trackcategory Trackcategory { get; set; }
    }
}
