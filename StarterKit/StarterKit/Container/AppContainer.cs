using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using StarterKit.Contracts.General;
using StarterKit.Contracts.Services.General;
using StarterKit.Services.General;
using StarterKit.ViewModels.Base;

namespace StarterKit.Container
{
    public class AppContainer
    {
        private static IContainer _container;

        /// <summary>
        /// Register dependenceies
        /// </summary>
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<LoginViewModel>();

            //Services
            builder.RegisterType<NavigationService>().As<INavigationService>();

            //General
            //builder.RegisterType<..>();

            _container = builder.Build();
        }

        /// <summary>
        /// Reslove by typeName
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        /// <summary>
        /// Resolve
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
