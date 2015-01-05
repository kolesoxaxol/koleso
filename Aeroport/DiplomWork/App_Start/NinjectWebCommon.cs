using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.IServices;
using BusinessLogicLayer.UnitOfWork;
using DAL;
using DiplomWork.App_Start;
using DiplomWork.Authorization;
using DiplomWork.Authorization.AuthInterface;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]
namespace DiplomWork.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<System.Web.IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IAirPlaneService>().To<AirPlanService>();
            kernel.Bind<ICityService>().To<CityService>();
            kernel.Bind<ICrewService>().To<CrewService>();
            kernel.Bind<IDispatcherRequestService>().To<DispatcherRequestService>();
            kernel.Bind<IFlightService>().To<FlightService>();
            kernel.Bind<IPositionService>().To<PositionService>();
            kernel.Bind<IRegisterService>().To<RegisterService>();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<IAuthenticationService>().To<AuthenticationService>().InRequestScope();
            kernel.Bind<IAuthentication>().To<Authentication>();
            kernel.Bind<MainContext>().ToSelf().InRequestScope();

            // kernel.Bind<ILogger>().To<LoggerAdapter>().WithConstructorArgument("logger", x => LogManager.GetLogger(x.Request.ParentContext.Request.Service.FullName));
        }
    }
}