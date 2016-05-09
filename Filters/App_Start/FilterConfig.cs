﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Filters.Infrastructure;
using System.Web.Mvc;

namespace Filters.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ProfileAllAttribute());
        }
    }
}