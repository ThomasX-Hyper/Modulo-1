using Damers.Data;
using Damers.Data.AccesoDatos;
using Microsoft.AspNetCore.Mvc;

namespace Damers.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProductoController(ApplicationDbContext context)
        {
            db = context;

        }
        public IActionResult Index()
        {

            var da=new DAEjecucion(db);
            var lista=da.GetProductos();
            return View(lista);
        }


        public IActionResult ProductoCompleto()
        {
            var dato = new DAEjecucion(db);
            var lista = dato.GetProductos();
            return View(lista);

        }
    }
}
