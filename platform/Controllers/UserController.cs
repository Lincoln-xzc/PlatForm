using Core.Entities;
using Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Controllers
{
  public class UserController : Controller
  {
    private readonly IUserService _userServcie;

   // private readonly ISearchServcie _searchService;

    public UserController(IUserService userService)
    {
      this._userServcie = userService;
    }

    public ActionResult List()
    {
      List<User> users = _userServcie.Search(c => !c.IsDel);
      return View(users);
    }
  }
}