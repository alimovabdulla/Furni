using Furni.Entities;
using Microsoft.EntityFrameworkCore;

namespace Furni.DataBAse
{
	public class FurniContext:DbContext
	{
        public FurniContext(DbContextOptions<FurniContext> dbContext): base(dbContext) 
        {
            


        }
        public DbSet<Cart> Carts { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Slide> Slides { get; set; }
	}
}
