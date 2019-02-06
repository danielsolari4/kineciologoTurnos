using relacionandoTablas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace relacionandoTablas.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            var a = new kineContext();
            a.Pacientes.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var kineContext = new kineContext();

            var paciente2 = kineContext.Pacientes.FirstOrDefault(x => x.Id == 2);



            var turno = new Turno() { Dia ="Lunes agregado", Paciente = paciente2 };

            kineContext.Turnos.Add(turno);
            var turno2 = new Turno() { Dia = "Jueves agregado", Paciente = paciente2 };
            kineContext.Turnos.Add(turno2);

            kineContext.SaveChanges();


            var pacienteDespues = kineContext.Pacientes.FirstOrDefault(x => x.Id == 2);

            var turnoDespues = pacienteDespues.Turnos;







            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}