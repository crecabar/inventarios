using Inventario.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Inventario.Models.ViewModels
{
    public class ProductCategoriesViewModel
    {
        public List<SelectListItem> ProductCategories { get; set; }
    }
}
