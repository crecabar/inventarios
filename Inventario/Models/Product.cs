using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
	public class Product
	{
		public required int ID { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; } = null;
		public required ProductCategory Category { get; set; }
	}
}

