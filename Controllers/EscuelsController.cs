using Back_endEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class EscuelsController : Controller
    {
        // GET: Escuels
        public ActionResult Index()
        {
            ViewBag.Nombre = "";
            ViewBag.Correo = "carlos@utleon.edu.mx";
            ViewBag.Fecha = new DateTime(2000, 5, 5);


            return View();
        }
        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Carlos";
            ViewData["Correo"] = "carlos@utleon.edu.mx";
            ViewData["Fecha"] = new DateTime(2000,5,5);

            return View();
        }
        public ActionResult Vista()
        {
            var persona = new Persona()
            {
                Nombre = "Carlos",
                Edad = 25,
                Empleado = true,
                Nacimiento = new DateTime(1998, 5, 6)

            };
            ViewBag.Propiedad = persona;
            return View();
        }
    }
}