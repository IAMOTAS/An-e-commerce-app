using System.ComponentModel.DataAnnotations;

namespace An_e_commerce_app.Models
{
    public class trackcategory
    {

        [Key]
        public int Id { get; set; }
        public string trackpictureURL { get; set; }

        public string trackname { get; set; }

        public string yearrecorded { get; set; }

        //Relationships
        public List<Track> Track { get; set; }

    }

}