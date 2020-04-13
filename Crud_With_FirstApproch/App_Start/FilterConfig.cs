using System.Web;
using System.Web.Mvc;

namespace Crud_With_FirstApproch
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
