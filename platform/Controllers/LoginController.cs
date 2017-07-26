using Core;
using Core.Entities;
using Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Controllers
{
  public class LoginController : Controller
  {

    IUserService _userService;

    public LoginController(IUserService userService)
    {
      this._userService = userService;
    }
    // GET: Login
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public string Index(User user)
    {
      User account = _userService.CheckLogin(user.Mobile, user.Password);
      Response result = new Response()
      {
        Message = "登录成功",
        Status = true,
        Code = ResultCode.Success,
        Result = account
      };
      return JsonHelper.Instance.Serialize(result);
    }

    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Register(User user)
    {
      User account = _userService.Register(user);
      return View();
    }
  }
}