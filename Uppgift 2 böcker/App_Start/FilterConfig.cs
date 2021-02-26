using System.Web;
using System.Web.Mvc;

namespace Uppgift_2_böcker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
