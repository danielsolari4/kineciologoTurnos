using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using relacionandoTablas.Models;

namespace relacionandoTablas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(User userParametro)
        {

            var kineContext = new kineContext();

            var usuario = kineContext.UsersTabla.Where(x => x.Userr == userParametro.Userr && x.Pass == userParametro.Pass).FirstOrDefault();

            if (usuario == null)
            {
                return View("Index", userParametro);
            }
            else
            {
                //Session["userID"] = userDetails.UserID;
                return RedirectToAction("Index", "Home");
            }

            
            
        }
    }
}