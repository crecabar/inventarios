using Inventario.net.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Inventario.net.ViewModels
{
    public class ProductCategoriesViewModel
    {
        public List<SelectListItem> ProductCategories { get; set; }
    }
}
