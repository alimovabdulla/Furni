using Furni.Entities;
 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Furni.DataBAse
{
	public class FurniContext: IdentityDbContext
	{
        public FurniContext(DbContextOptions<FurniContext> dbContext) : base(dbContext)
        {
             
        }
        public DbSet<Cart> Carts { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Slide> Slides { get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TestiMonials> TestiMonial { get; set; }
        public DbSet<AppUser> appUsers { get; set; }
        
    }
    
}
