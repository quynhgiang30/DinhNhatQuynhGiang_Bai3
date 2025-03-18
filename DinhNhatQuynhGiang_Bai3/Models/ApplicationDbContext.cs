using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DinhNhatQuynhGiang_Bai3.Models;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    // Các DbSet khác nếu cần
}
