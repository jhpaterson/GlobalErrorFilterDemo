using System.Web;
using System.Web.Mvc;
using System;

namespace GlobalErrorFilterDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleErrorAttribute
            {
                ExceptionType = typeof(NotImplementedException),
                View = "NotImplemented",
                Order = 2
            });
        }
    }
}