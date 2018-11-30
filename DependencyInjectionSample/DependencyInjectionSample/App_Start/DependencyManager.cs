using Autofac;
using Autofac.Integration.Mvc;
using DependencyInjectionSample.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectionSample.App_Start
{
    public class DependencyManager
    {
        public static void Register()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ProductRepository>().As<IProductRepository>();

            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());

            var container = containerBuilder.Build();

          
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}