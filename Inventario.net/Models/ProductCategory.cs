using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.net.Models
{
    public class ProductCategory
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
