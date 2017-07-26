using Core;
using Core.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Controllers
{
  public class BaseController : Controller
  {
    public const string Token = "Token";
    protected Response Result = new Response();
    protected string ControllerName;
    protected string ActionName;

    protected override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      base.OnActionExecuting(filterContext);

      var token = "";
      var Request = filterContext.HttpContext.Request;

      if(Request.QueryString[Token] != null)
      {
        token = Request.QueryString[Token];
        var cookie = new HttpCookie(Token, token)
        {
          Expires = DateTime.Now.AddDays(2)
        };
        filterContext.HttpContext.Response.Cookies.Add(cookie);
      }else if(Request.Cookies[Token] != null)
      {
        token = Request.Cookies[Token].Value;
      }

      if (string.IsNullOrEmpty(token))
      {
        filterContext.Result = LoginResult("");
        return;
      }
      else
      {
        ObjCacheProvider<UserAuthSession> objCache = new ObjCacheProvider<UserAuthSession>();
        if(objCache.GetCache(token) != null)
        {
          ControllerName = Request.RequestContext.RouteData.Values["controller"].ToString().ToLower();
          ActionName = filterContext.ActionDescriptor.ActionName.ToLower();

          var function = this.GetType().GetMethods().FirstOrDefault(u => u.Name.ToLower() == ActionName);
          if (function == null)
            throw new Exception("未能找到Action");
        }
        else
        {
          filterContext.Result = LoginResult("");
          return;
        }
      }

    }
    public virtual ActionResult LoginResult(string username)
    {
      return new RedirectResult("/Login/Index");
    }
  }
}