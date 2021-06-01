using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public double Whatsapp { get; set; }
        

        public string Photo { get; set; }
    }
}
