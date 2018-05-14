using System.Web;
using System.Web.Mvc;

namespace plentyLeadsSampleWork201805
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
