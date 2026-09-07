using Damers.Data;
using Damers.Data.AccesoDatos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Damers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    [EnableCors("AngularPolicy")]

    public class BackProductoController : ControllerBase
    {
        private readonly DAEjecucion da;

        public BackProductoController(DAEjecucion da)
        {
            this.da = da;

        }
        [HttpGet("listar")]
        public IActionResult Index()
        {
            var datos=da.GetProductos();

            return Ok(datos);
        }
    }
}
