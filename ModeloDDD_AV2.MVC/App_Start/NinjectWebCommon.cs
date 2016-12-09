[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ModeloDDD_AV2.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ModeloDDD_AV2.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ModeloDDD_AV2.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Application.Interface;
    using Application;
    using Domain.Interfaces.Services;
    using Domain.Services;
    using Domain.Interfaces.Repositories;
    using Infra.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
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
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

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
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IProcessoAppService>().To<ProcessoAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<IAutoDeInfracaoAppService>().To<AutoDeInfracaoAppService>();
            kernel.Bind<IEnderecoAppService>().To<EnderecoAppService>();
            kernel.Bind<IFornecedorAppService>().To<FornecedorAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IProcessoService>().To<ProcessoService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<IAutoDeInfracaoService>().To<AutoDeInfracaoService>();
            kernel.Bind<IEnderecoService>().To<EnderecoService>();
            kernel.Bind<IFornecedorService>().To<FornecedorService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>)); 
            kernel.Bind<IProcessoRepository>().To<ProcessoRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            kernel.Bind<IAutoDeInfracaoRepository>().To<AutoDeInfracaoRepository>();
            kernel.Bind<IEnderecoRepository>().To<EnderecoRepository>();
            kernel.Bind<IFornecedorRepository>().To<FornecedorRepository>();
        }        
    }
}
