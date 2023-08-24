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

    }
}
