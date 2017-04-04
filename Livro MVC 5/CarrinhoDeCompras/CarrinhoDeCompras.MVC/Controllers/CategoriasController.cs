using CarrinhoDeCompras.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CarrinhoDeCompras.MVC.Controllers
{
    public class CategoriasController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(categorias.OrderBy(x => x.Nome));
        }

        [HttpGet]
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

        [HttpGet]
        public ActionResult Edit(long id)
        {
            return View(categorias.FirstOrDefault(x => x.CategoriaId == id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            categorias.Remove(categorias.FirstOrDefault(x => x.CategoriaId == categoria.CategoriaId));
            categorias.Add(categoria);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Details(long id)
        {
            return View(categorias.FirstOrDefault(x => x.CategoriaId == id));
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            return View(categorias.FirstOrDefault(x => x.CategoriaId == id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(Categoria categoria)
        {
            categorias.Remove(categorias.FirstOrDefault(x => x.CategoriaId == categoria.CategoriaId));
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