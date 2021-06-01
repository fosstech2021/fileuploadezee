using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasePackageModule1.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }

        [Required]
        public string  Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ConatctNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        public string Location { get; set; }

    }
}
