using BackEndWebAppEjecuciones_DSI_26_II.Data.AccesoDatos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEndWebAppEjecuciones_DSI_26_II.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    [EnableCors("AngularPolicy")]
    public class BackEjecucionesController : ControllerBase
    {
        [HttpGet("listar")]
        public IActionResult Index()
        {
            var model=new DADetalleEjecuciones();
            var datos = model.GetDetalleOperacion();
            return Ok(datos);
        }
    }
}
