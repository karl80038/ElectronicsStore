using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicsStore.Models
{
	public class Cart
	{
		public Guid Id { get; set; }
		public double Sum { get; set; }
		public DateTime DateCreated { get; set; }
		public bool Paid { get; set; }
		public virtual ICollection<Item> Items { get; set; }

		public Cart()
		{
			Id = Guid.NewGuid();
			Sum = 0;
			DateCreated = DateTime.Now;
			Items = new List<Item>();
		}

		public void AddToCart(Item electronics)
		{
			Items.Add(electronics);
			Sum += electronics.Price;
		}
	}
}