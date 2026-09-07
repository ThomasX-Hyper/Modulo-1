using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppEjecuciones_DSI_26_II.Models;

namespace WebAppEjecuciones_DSI_26_II.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(){
        
        }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<CabeceraOperacion> CabeceraOperacion { get; set; }
        public virtual DbSet<DetalleOperaciones> DetalleOperacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-JC5GM4OO\\SQLEXPRESS04;" +
                "Database=DBEjecucion_TDS_26_II;" +
                "User Id=sa;" +
                "Password=123;" +
                "MultipleActiveResultSets=True;" +
                "Encrypt=False"
            );
        }

    }
}