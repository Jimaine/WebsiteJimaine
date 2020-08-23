using System.Web;
using System.Web.Mvc;

namespace WebsiteJimaine
{
    /// <summary>
    /// MVC Config for Filters
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Register Filter
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
