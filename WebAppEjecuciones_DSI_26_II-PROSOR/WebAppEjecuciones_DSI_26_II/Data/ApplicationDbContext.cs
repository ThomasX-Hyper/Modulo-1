using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BackEndWebAppEjecuciones_DSI_26_II.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
            {

        }
    public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
        public virtual DbSet<BackEndWebAppEjecuciones_DSI_26_II.Models.CabeceraOperacion> CabeceraOperacion { get; set; }
        public virtual DbSet<BackEndWebAppEjecuciones_DSI_26_II.Models.DetalleOperacion> DetalleOperacion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-6A4CUQNN\\SQLEXPRESS;" +
                "Database=DBEjecucion_TDS_26_II;" +
                "User id=sa;Password=123;MultipleActiveResultSets=True;Encrypt=False");
        }
    }
}
