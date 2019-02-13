using relacionandoTablas.Filter4Niggas;
using System.Web;
using System.Web.Mvc;

namespace relacionandoTablas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ActionFilter());
        }
    }
}
