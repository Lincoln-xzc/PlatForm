using Core.Entities.User;
using Services;
using Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Controllers
{
  public class UserController : Controller
  {

    private readonly IUserService _userService;

    private readonly ISearchService<User> _searchService;

    public UserController(IUserService userService,ISearchService<User> searchService)
    {
      this._userService = userService;

    }

    // GET: User
    public ActionResult List()
    {
      _userService.search();
      return View();
    }
  }
}