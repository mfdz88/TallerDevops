﻿using System.Web;
using System.Web.Mvc;

namespace Ejercicio1SitioWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
