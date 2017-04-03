using CarrinhoDeCompras.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CarrinhoDeCompras.MVC.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }

        //GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaId = categorias.Select(x => x.CategoriaId).Max() + 1;
            return RedirectToAction(nameof(Index));
        }

        //TODO retirar depois
        private static IList<Categoria> categorias =
                                                                                            new List<Categoria>()
                                            {
                                                                new Categoria() {
                                                                                CategoriaId =   1,
                                                                                Nome    =   "Notebooks"
                                                                },
                                                                new Categoria() {
                                                                                CategoriaId =   2,
                                                                                Nome    =   "Monitores"
                                                                },
                                                                new Categoria() {
                                                                                CategoriaId =   3,
                                                                                Nome    =   "Impressoras"
                                                                },
                                                                new Categoria() {
                                                                                CategoriaId =   4,
                                                                                Nome    =   "Mouses"
                                                                },
                                                                new Categoria() {
                                                                                CategoriaId =   5,
                                                                                Nome    =   "Desktops"
                                                                }
                                            };
    }
}