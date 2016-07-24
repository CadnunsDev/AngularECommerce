using System.Web;
using System.Web.Mvc;

namespace CadnunsDev.AngularECommerce.UI.Admin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
