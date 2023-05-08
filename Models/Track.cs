using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace An_e_commerce_app.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        public string? trackURL { get; set; }

        public string? trackname { get; set; }

        public string? owmer { get; set; }

        //Relationships
        public List<artist_Track> artist_Track { get; set; }

        // Studio

        public int studioid { get; set; }
        [ForeignKey("studioid")]
        public studio studio { get; set; }

        public int artistid { get; set; }
        [ForeignKey("artistid")]
        public studio artist { get; set; }

    }
}
