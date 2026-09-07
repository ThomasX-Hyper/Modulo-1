using Damers.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Damers.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {

        public DbSet<TipoProducto> Tipo_Producto{ get; set; }
        public DbSet<Producto> Producto{ get; set; }
    }
}
