﻿using System.Web;
using System.Web.Mvc;

namespace Examen2_Elizondo_Lucia
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
