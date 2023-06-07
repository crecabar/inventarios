using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.net.Models
{
    public class InventoryProduct
    {
        public required int Id { get; set; }
        public required Product Product { get; set; }
        public required Inventory Inventory { get; set; }
        public int CountedAmount { get; set; } = 0;
        public int CurrentAmount { get; set; } = 0;

    }
}
