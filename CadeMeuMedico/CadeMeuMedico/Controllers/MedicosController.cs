using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadeMeuMedico.Models;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : Controller
    {
        private EntidadesCadeMeuMedicoBD db = new EntidadesCadeMeuMedicoBD();


        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include("Cidades").Include("Especialidades");
            return View(medicos.ToList());
        }
    }
}