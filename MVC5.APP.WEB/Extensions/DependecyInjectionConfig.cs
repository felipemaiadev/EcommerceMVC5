using System.Web;
using System.Web.Mvc;
using MVC5.APP.APPLICATION.Produtos.Services;
using MVC5.APP.APPLICATION.Produtos.Services.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Services;
using MVC5.APP.DOMAIN.Produtos.Services.Interfaces;
using MVC5.APP.INFRA.Produtos.Respositories;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace MVC5.APP.WEB.Extensions
{
    public static class DependecyInjectionConfig
    {
        static readonly Container container = new Container();
        public static void DependecyInjectionSetup(this HttpApplication app)
        {
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<IProdutoRepository, ProdutoRepositorySQLSERVER>(Lifestyle.Scoped);
            container.Register<IProdutoService, ProdutoService>(Lifestyle.Scoped);
            container.Register<IProdutoAppService, ProdutoAppService>(Lifestyle.Scoped);

            //container.RegisterResolver();

            //container.Verify();

            //DependencyResolver.SetResolver(new SimpleInjectorDependecyResolver());
        }
    }
}