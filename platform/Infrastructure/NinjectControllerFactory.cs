using Core.Abstract;
using Core.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace platform.Infrastructure
{
  public class NinjectControllerFactory : DefaultControllerFactory
  {
    private IKernel ninjectKernel;

    public NinjectControllerFactory()
    {
      ninjectKernel = new StandardKernel();
      AddBindings();
    }

    protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
    {
      return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
    }

    private void AddBindings()
    {
      ninjectKernel.Bind<IUserRepository>().To<UserRepository>();
    }
  }
}