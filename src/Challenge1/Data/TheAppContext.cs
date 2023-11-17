using Challenge1.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge1.Data
{
	public class TheAppContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }

		public TheAppContext(DbContextOptions<TheAppContext> options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase(DbData.DbName);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>().HasKey(c => c.Id);
			modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired();
			modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired();
		}
	}
}
