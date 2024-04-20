using L02P02_2022_QR_601_2021_AA_651.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace L02P02_2022_QR_601_2021_AA_651.Controllers
{
	public class LibrosController : Controller
	{
		private readonly libreriaDbContext _libreriaDbContext;

		public LibrosController(libreriaDbContext libreriaDbContext)
		{
			_libreriaDbContext = libreriaDbContext;
		}

		public IActionResult Index()
		{
			var listaDeAutor = (from a in _libreriaDbContext.autores
								select a).ToList();
			ViewData["listadoDeAutor"] = new SelectList(listaDeAutor, "id", "autor");

			var listaDeCategoria = (from c in  _libreriaDbContext.categorias
									select c).ToList();
			ViewData["listadoDeCategoria"] = new SelectList(listaDeCategoria, "id", "categoria");


			var listadoDeLibros = (from l in _libreriaDbContext.libros
								   join a in _libreriaDbContext.autores on l.id equals a.id
								   join c in _libreriaDbContext.categorias on l.id equals c.id
								   select new
								   {
									   nombre = l.nombre,
									   descripcion = l.descripcion,
									   precio = l.precio,
									   autor = a.autor,
									   categoria = c.categoria

								   }).ToList();
			ViewData["listadoDeLibros"] = listadoDeLibros;

			return View();
		}

		public IActionResult CrearLibros(libros nuevoLibro)
		{
			_libreriaDbContext.Add(nuevoLibro);
			_libreriaDbContext.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
