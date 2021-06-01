using System.ComponentModel.DataAnnotations;

namespace BasePackageModule1.Models
{
    public class SliderImage
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }

        [MaxLength(200)]
        public string Heading { get; set; }
        [MaxLength(190)]
        public string ShortDescription { get; set; }
    }
}