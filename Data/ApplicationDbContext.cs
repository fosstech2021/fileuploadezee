using BasePackageModule1.Models;
using BasePackageModule1.Models.Menu;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasePackageModule1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
       
        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<ReceivedAgreement> ReceivedAgreement { get; set; }
        public DbSet<AgreementDetails> AgreementDetails { get; set; }
        

        public DbSet<SliderImage> SliderImages { get; set; }
      
        public DbSet<Banner> Banners { get; set; }
        
        public DbSet<Page> Pages { get; set; }
       
        public DbSet<Post> Posts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Owner> Owners { get; set; }



        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<Seo> Seo { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        

        public DbSet<BusinessProfile> BusinessProfile { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuProduct> MenuProducts { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<faq> Faqs { get; set; }
        public DbSet<Agreement> Agreements { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
              
            builder.Entity<Category>()
                .HasMany(p => p.SubCategories)
                .WithOne(t => t.Category)
                .OnDelete(DeleteBehavior.SetNull);
        }

    }
}
