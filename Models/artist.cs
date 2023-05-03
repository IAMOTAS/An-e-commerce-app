using System.ComponentModel.DataAnnotations;

namespace An_e_commerce_app.Models
{
    public class artist
    {
        [Key]
        public int Id { get; set; }
        public string? profilepictureURL { get; set; }

        public string? artistname { get; set; }

        public string? yearproduced { get; set; }
    }
}
