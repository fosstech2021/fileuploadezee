using System;
using System.ComponentModel.DataAnnotations;

namespace BasePackageModule1.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public int Order { get; set; }
        public string Content { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CreatedAt { get; set; }

        public Page()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
