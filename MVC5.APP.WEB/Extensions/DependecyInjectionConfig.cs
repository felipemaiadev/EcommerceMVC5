using AutoMapper;
using MVC5.APP.APPLICATION.Produtos.Services;
using MVC5.APP.APPLICATION.Produtos.Services.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Repositories.Interfaces;
using MVC5.APP.DOMAIN.Produtos.Services;
using MVC5.APP.DOMAIN.Produtos.Services.Interfaces;
using MVC5.APP.INFRA.Produtos.Context;
using MVC5.APP.INFRA.Produtos.Respositories;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Web;
using System.Web.Mvc;

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
            container.Register<SystemContext>(Lifestyle.Scoped);


            var configMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps("MVC5.APP.APPLICATION");
            });

            container.RegisterInstance(configMapper);
            container.Register<IMapper>(() => configMapper.CreateMapper(container.GetInstance));

            container.RegisterMvcControllers();

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }

        public static Container GetContainer()
        {
            return container;
        }
    }
}