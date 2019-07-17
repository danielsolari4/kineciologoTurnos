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
                HttpCookie cookie = new HttpCookie("adid");
                cookie.Values["logueado"] = "true";
                cookie.Expires = DateTime.Now.AddDays(1);

                HttpContext.Response.Cookies.Add(cookie);

                

                //Session["userID"] = userDetails.UserID;
                //usuario.Logueado = 1;
                //kineContext.SaveChanges();
                return RedirectToAction("Index", "Home");
                
            }

            
            
        }
        
        public ActionResult LogOff()
        {
            HttpCookie cookie = new HttpCookie("adid");
            cookie.Values["logueado"] = "false";

            cookie.Expires = DateTime.Now.AddDays(-1);

            HttpContext.Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Login");


            //var kineContext = new kineContext();

            //var usuario = kineContext.UsersTabla.Where(x => x.Userr == userParametro.Userr && x.Pass == userParametro.Pass).FirstOrDefault();

            //if (usuario == null)
            //{
            //    return View("Index", userParametro);
            //}
            //else
            //{
            //    HttpCookie cookie = new HttpCookie("adid");
            //    cookie.Values["logueado"] = "false";
            //    cookie.Expires = DateTime.Now.AddDays(1);

            //    HttpContext.Response.Cookies.Add(cookie);



            //    //Session["userID"] = userDetails.UserID;
            //    //usuario.Logueado = 1;
            //    //kineContext.SaveChanges();
            //    return RedirectToAction("Index", "Pacientes");

            //} 



        }
    }
}