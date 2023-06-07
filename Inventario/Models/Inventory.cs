using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Inventory
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }
}
