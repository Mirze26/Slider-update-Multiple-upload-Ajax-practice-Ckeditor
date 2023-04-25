using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_Slider.Models
{
    public class SliderInfo:BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? SignatureImage { get; set; }
        [Required(ErrorMessage = "Don't be empty")]
        [NotMapped]                                       
        public IFormFile Photo { get; set; }             

    }
}
