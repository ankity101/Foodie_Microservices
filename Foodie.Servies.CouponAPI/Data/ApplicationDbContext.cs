using Foodie.Servies.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodie.Servies.CouponAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
                
        }

        public DbSet<Coupon> Coupons    { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(
               new Coupon
               {
                   CouponId = 1,
                   CouponCode = "DIS100",
                   DiscountAmount = 100,
                   MinAmount = 1000
               },
               new Coupon
               {
                   CouponId = 2,
                   CouponCode = "DIS50",
                   DiscountAmount =50,
                   MinAmount = 500
               }
               ) ;
        }
    }
}
