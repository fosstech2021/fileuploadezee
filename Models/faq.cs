using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class faq
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Question { get; set; }
        public string Answere { get; set; }
    }
}
