
using relacionandoTablas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace relacionandoTablas.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        
        public kineContext db = new kineContext();

        public ActionResult Index()
        {

            var listaTurnos = db.Turnos.ToList();


            var a = new kineContext();
            a.Pacientes.ToList();

            
            return View(listaTurnos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var kineContext = new kineContext();

 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}