﻿namespace Project.Web.Api
{
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;


    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
