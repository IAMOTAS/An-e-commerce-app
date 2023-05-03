using System.ComponentModel.DataAnnotations;

namespace An_e_commerce_app.Models
{
    public class studio
    {
        [Key]
        public int Id { get; set; }
        public string? studiopictureURL { get; set; }

        public string? studioname { get; set; }

        public string? yearbuilt { get; set; }
    }
}
