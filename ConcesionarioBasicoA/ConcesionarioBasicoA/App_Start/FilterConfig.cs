using System.Web;
using System.Web.Mvc;

namespace ConcesionarioBasicoA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
