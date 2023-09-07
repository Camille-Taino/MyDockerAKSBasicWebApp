using System.ComponentModel.DataAnnotations;

namespace MyBasicWebApp.Models
{
    public class PlaceCollectionItem
    {
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
