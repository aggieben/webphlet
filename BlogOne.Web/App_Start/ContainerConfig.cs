using System.Web.Configuration;
using System.Web.Mvc;
using BlogOne.Common.Data;
using BlogOne.Web.Controllers;
using BlogOne.Web.Data;
using Munq;

namespace BlogOne.Web {
	public static class ContainerConfig {
		public static void RegisterContainer() 
        {
			DependencyResolver.SetResolver(new Mvc.DependencyResolver(BuildContainer()));
		}

        public static IocContainer BuildContainer()
        {
            var ioc = new IocContainer();

            ioc.Register<IDbConnectionFactory>(c => new SqlConnectionFactory(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));

            // repositories
            ioc.Register<IPostRepository, PostRepository>();

            // controllers
            ioc.Register(c => new HomeController(c.Resolve<IPostRepository>()));
            ioc.Register(c => new PostController(c.Resolve<IPostRepository>()));

            return ioc;
        }
	}
}