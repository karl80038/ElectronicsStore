using ElectronicsStore.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ElectronicsStore.DatabaseContext
{
	public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<ElectronicsStoreDbContext>
	{
		protected override void Seed(ElectronicsStoreDbContext context)
		{
			context.Items.AddOrUpdate(
				x => x.Name,
				new Item
				{
					Name = "",
					Category = Category.Laptop,
					Manufacturer = "HP",
					Price = 1
				},
				new Item
				{
					Name = "",
					Manufacturer = "",
					Price = 0.8
				},
				new Item
				{
					Name = "",
					Manufacturer = "",
					Price = 1.1
				},
				new Item
				{
					Name = "",
					Manufacturer = "",
					Price = 2
				},
				new Item
				{
					Name = "",
					Manufacturer = "",
					Price = 0.6
				}
			);
		}
	}
}