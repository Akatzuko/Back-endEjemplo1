using Back_endEjemplo1.Models;
using Back_endEjemplo1.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string n1, string n2)
        {
            int resultado = 0;
            resultado = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = resultado;

            return View();
        }
        public ActionResult Operacion()
        {
            OperaBas op = new OperaBas();
            return View(op);
        }
        [HttpPost]

        public ActionResult Operacion(OperasBas op)
        {
            //op.Suma();
            return View(op);
        }
        public ActionResult Resta(OperasBas op)
        {
            //op.Resta();
            return View(op);
        }
        public ActionResult MuestraPeliculas()
        {
            var peliculaservice = new PeliculasServices();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }

        public ActionResult MuestraPeliculas2()
        {
            var peliculaservice = new PeliculasServices();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }

    }
    
}