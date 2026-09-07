using BackEndWebAppEjecuciones_DSI_26_II.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndWebAppEjecuciones_DSI_26_II.Data.AccesoDatos
{
    public class DADetalleEjecuciones
    {
        public IEnumerable<DetalleOperacion> GetDetalleOperacion()
        {
            var DetOperacion = new List<DetalleOperacion>();
            using (var db=new ApplicationDbContext())
            {
                DetOperacion = db.DetalleOperacion.
                    Include(item => item.CabeceraOperacion).ToList();
            }
            return DetOperacion;
        }

    }

}
