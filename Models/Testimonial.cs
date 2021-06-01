using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Comment { get; set; }
        public string Photo { get; set; }
    }
}
