using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using platform.Infrastructure;

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
      ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
    }
  }
}
