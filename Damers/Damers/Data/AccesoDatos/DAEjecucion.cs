using Damers.Models;
using Microsoft.EntityFrameworkCore;

namespace Damers.Data.AccesoDatos
{
    public class DAEjecucion
    {
        private readonly ApplicationDbContext db;

        public DAEjecucion(ApplicationDbContext context){
            db = context;
            
        }
        public IEnumerable<Producto> GetProductos()
        {
            return db.Producto.Include(item => item.TipoProducto).ToList();

        }
    }
}
