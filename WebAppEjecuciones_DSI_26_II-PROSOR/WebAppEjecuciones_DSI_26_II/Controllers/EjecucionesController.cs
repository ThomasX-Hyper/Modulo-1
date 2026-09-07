using BackEndWebAppEjecuciones_DSI_26_II.Data.AccesoDatos;
using Microsoft.AspNetCore.Mvc;

namespace BackEndWebAppEjecuciones_DSI_26_II.Controllers
{
    public class EjecucionesController : Controller
    {
        public IActionResult Index()
        {
            var ObjDetalleEjecucion = new DADetalleEjecuciones();
            var model=ObjDetalleEjecucion.GetDetalleOperacion();
            return View(model);
        }
        public IActionResult VBEjecuciones()
        {
            var ObjVBEjecuciones = new DADetalleEjecuciones();
            ViewBag.Ejecuciones = ObjVBEjecuciones.GetDetalleOperacion();
            return View();
        }
    }
}
