using System.ComponentModel.DataAnnotations;

namespace An_e_commerce_app.Models
{
    public class artist
    {
        [Key]
        public int Id { get; set; }
        public string artistpictureURL { get; set; }

        public string artistname { get; set; }

        public string artistdescription { get; set; }

        //Relationships
        public List<Track> Track { get; set; }

    }
}
