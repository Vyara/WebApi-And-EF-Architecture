﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Project.Common.Constants;

[assembly: OwinStartup(typeof(Project.Web.Api.Startup))]

namespace Project.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfig.RegisterMappings(Assemblies.WebApi);

            //TODO: Initialize DB           
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShowcaseDbContext, Configuration>());
            ConfigureAuth(app);

            var httpConfig = new HttpConfiguration();

           // ODataConfig.Register(httpConfig);
            WebApiConfig.Register(httpConfig);

            httpConfig.EnsureInitialized();

            app
                .UseNinjectMiddleware(NinjectConfig.CreateKernel)
                .UseNinjectWebApi(httpConfig);
        }
    }
}
