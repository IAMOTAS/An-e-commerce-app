using System.ComponentModel.DataAnnotations;

namespace An_e_commerce_app.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        public string? trackURL { get; set; }

        public string? trackname { get; set; }

        public string? owmer { get; set; }


    }
}
