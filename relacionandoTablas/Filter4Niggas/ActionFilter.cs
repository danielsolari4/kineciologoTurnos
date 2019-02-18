using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace relacionandoTablas.Filter4Niggas
{
    public class ActionFilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            var url = filterContext.HttpContext.Request.Url;
            bool logueado = false;
            var c = filterContext.HttpContext.Request.RequestContext.RouteData.Values["controller"];

            if (filterContext.HttpContext.Request.Cookies["adid"] != null)
            {
                logueado = Convert.ToBoolean(filterContext.HttpContext.Request.Cookies["adid"]["logueado"]);
                if (logueado)
                    return;
                else
                {
                    if (c.ToString().ToLower() != "login")
                    {
                    
                        GoToLogin(filterContext);
                    }
                }
            }
            else
            {
                
                if (c.ToString().ToLower() != "login")
                {
                    GoToLogin(filterContext);
                }
            }



        }



        private void GoToLogin(ActionExecutingContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" } });
            return;
        }
    }
}