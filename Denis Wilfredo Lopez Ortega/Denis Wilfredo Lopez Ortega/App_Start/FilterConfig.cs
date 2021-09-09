using System.Web;
using System.Web.Mvc;

namespace Denis_Wilfredo_Lopez_Ortega
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
