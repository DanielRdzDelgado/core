using Microsoft.AspNetCore.Mvc;
using Tienda.Datos;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class CategoriaController : Controller
    {

        //creamos una propiedad par conectarnos a la base de datos
        private readonly ApplicationDBContext _db; //esta variable siempre tiene los datos de la BD

        public CategoriaController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = _db.Categoria; //gusradmos la lista de categorias
            return View(lista);
        }


        //crear categoria (VISTA)
        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Categoria categoria)
        {
            //agregamos a la tabla
            _db.Categoria.Add(categoria);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        //editar categoria
        public IActionResult Edit()
        {
            return View();
        }


    }
}
