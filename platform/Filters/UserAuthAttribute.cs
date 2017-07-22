using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Filters
{
  public class UserAuthAttribute : AuthorizeAttribute
  {
    private bool localAllowed;

    public UserAuthAttribute(bool allowedParam)
    {
      localAllowed = allowedParam;
    }

    protected override bool AuthorizeCore(HttpContextBase httpContext)
    {
      if (httpContext.Request.IsLocal)
        return localAllowed;
      else
        return true;
    }
  }
}