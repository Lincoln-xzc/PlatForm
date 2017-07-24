using Autofac;
using Core.Data;
using Data;
using Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace platform.Infrastructure
{
  public class AutoFaceControllerFactory
  {
    internal static void SetupResolveRules(ContainerBuilder builder)
    {
      builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>));
      //builder.RegisterType<UserService>().As<IUserService>();
      builder.RegisterAssemblyTypes(Assembly.Load("Service"))
        .Where(c => c.Name.EndsWith("Service"))
        .AsImplementedInterfaces()
        .InstancePerLifetimeScope();
    }
  }
}