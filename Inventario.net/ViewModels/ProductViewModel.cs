using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inventario.ViewModels
{
    public class ProductViewModel
    {
        public required int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
        public required List<SelectListItem> Category { get; set; }
    }
}
