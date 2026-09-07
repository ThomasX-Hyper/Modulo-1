using Microsoft.EntityFrameworkCore;
using WebAppEjecuciones_DSI_26_II.Models;

namespace WebAppEjecuciones_DSI_26_II.Data.AccesoDatos
{
    public class DADetalleEjecuciones
    {

        public IEnumerable<DetalleOperaciones> GetDetalleOperaciones()
        {
            var DetOperacion = new List<DetalleOperaciones>();
            using(var db=new ApplicationDbContext())
            {

                DetOperacion=db.DetalleOperacion.Include(item=>item.CabeceraOperacion).ToList();
            }

            return DetOperacion;

            }
    }
}
