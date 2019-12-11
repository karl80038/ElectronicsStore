using ElectronicsStore.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ElectronicsStore.DatabaseContext
{
	public class ElectronicsStoreDbContext : DbContext
	{
		private object modelBuilder;
		public DbSet<Item> Items { get; set; }
		public DbSet<Cart> ShoppingCarts { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}