using System;
using System.ComponentModel.DataAnnotations;


namespace Inventario.net.Models
{
	public class Product
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public int CurrentAmount { get; set; }
		public int CountedAmount { get; set; }
	}
}

