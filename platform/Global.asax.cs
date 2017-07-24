using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using platform.Infrastructure;
using Autofac;
using Data;
using Core.Data;
using System.Reflection;
using Autofac.Integration.Mvc;
using Service.Users;

namespace platform
{
  public class Global : HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      RouteConfig.RegisterRoutes(RouteTable.Routes);

      //设置controller工厂
      //  ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
      var builder = new ContainerBuilder();
      AutoFaceControllerFactory.SetupResolveRules(builder);
      builder.RegisterControllers(Assembly.GetExecutingAssembly());
      var container = builder.Build();
      DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

    }
  }
}
