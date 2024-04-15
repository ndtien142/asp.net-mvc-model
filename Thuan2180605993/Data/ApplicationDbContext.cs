using Microsoft.EntityFrameworkCore;
using Thuan2180605993.Models.Entites;

namespace Thuan2180605993.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
		{
		}

		public DbSet<Admin> Admin { get; set; }
		public DbSet<Banner> Banner { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Item> Item { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<OrderDetail> OrderDetail { get; set; }
		public DbSet<ItemType> ItemType { get; set; }
		public DbSet<Menu> Menu { get; set; }
		public DbSet<Payment> Payment { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Admin>().HasKey(e => e.Username);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurcharsePrice)
				.HasColumnType("decimal(18, 0)"); 

			modelBuilder.Entity<Item>()
				.Property(e => e.SellPrice)
				.HasColumnType("decimal(18, 0)"); 

			modelBuilder.Entity<Order>()
				.Property(e => e.Totalprice)
				.HasColumnType("decimal(18, 0)"); 

			modelBuilder.Entity<OrderDetail>()
				.Property(e => e.Totalprice)
				.HasColumnType("decimal(18, 0)");

			modelBuilder.Entity<Payment>()
				.Property(e => e.Payprices)
				.HasColumnType("decimal(18, 0)");
		}

	}
}
