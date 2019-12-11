using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicsStore.Models
{
	public enum Category { Laptop, Mobile_Phone, TV }
	public class Item
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Category Category { get; set; }
		public string Manufacturer { get; set; }
		public double Price { get; set; }
		public virtual ICollection<Cart> Carts { get; set; }

		public Item()
		{
			Id = Guid.NewGuid();
		}

		public Item(string name, double price)
		{
			Name = name;
			Price = price;
		}
	}
}