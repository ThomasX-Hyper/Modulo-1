using Microsoft.AspNetCore.Mvc;
using WebAppEjecuciones_DSI_26_II.Data.AccesoDatos;

namespace WebAppEjecuciones_DSI_26_II.Controllers
{
    public class EjecucionesController : Controller
    {
        public IActionResult Index()
        {

            var ObjDetalleEjecucion=new  DADetalleEjecuciones();    
            var model = ObjDetalleEjecucion.GetDetalleOperaciones();  
            

            return View(model);
        }

        public IActionResult VBEjecuciones()
        {
            var ObjVBEjecuciones = new DADetalleEjecuciones();
            ViewBag.Ejecuciones =ObjVBEjecuciones.GetDetalleOperaciones();

            return View();
        }
    }
}
