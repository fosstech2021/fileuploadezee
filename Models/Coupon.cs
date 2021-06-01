﻿using System.ComponentModel.DataAnnotations;

namespace BasePackageModule1.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CouponType { get; set; }
        public enum ECouponType { Percent =0, Inr=1}
        [Required]
        public double Discount { get; set; }
        [Required]
        public double MinimumAmount { get; set; }
        public byte[] Picture { get; set; }

        public bool IsActive { get; set; }
    }
}
