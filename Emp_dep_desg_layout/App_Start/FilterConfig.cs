using System.Web;
using System.Web.Mvc;

namespace Emp_dep_desg_layout
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
