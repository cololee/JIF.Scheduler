﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JIF.Scheduler.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Init DI
            //DependencyRegistrar.RegisterDependencies();
            DIContainerManager.Initialize();


            // Init Scheduler
            SchedulerConfig.Init();
        }
    }
}
