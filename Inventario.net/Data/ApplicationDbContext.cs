using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inventario.net.Models;

namespace Inventario.net.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Product { get; set; } = default!;

    public DbSet<Inventory> Inventory { get; set; } = default!;

    public DbSet<InventoryProduct> InventoryProduct { get; set; } = default!;

    public DbSet<Inventario.net.Models.ProductCategory> ProductCategory { get; set; } = default!;
}

