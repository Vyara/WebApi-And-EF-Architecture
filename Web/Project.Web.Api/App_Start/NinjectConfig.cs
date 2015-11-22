namespace Project.Web.Api
{
    using System;
    using System.Data.Entity;
    using System.Web;
    using Common.Constants;

    using Ninject;
    // using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;

    using Data;
    using Data.Contracts;
    using Data.Repositories;

    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                //ObjectFactory.Initialize(kernel);
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof (IRepository<>)).To(typeof (EfGenericRepository<>));
            kernel.Bind<IProjectDbContext>().To<ProjectDbContext>().InRequestScope();

            //kernel.Bind(b => b.From(Assemblies.DataServices)
            //.SelectAllClasses()
            //.BindDefaultInterface());
        }
    }
}