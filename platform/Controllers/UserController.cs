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

    public UserController(IUserService userService)
    {
      this._userService = userService;

    }

    // GET: User
    public ActionResult List()
    {
<<<<<<< HEAD
      _userService.search();
      return View();
=======
       // private readonly IUserService _userService;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
>>>>>>> 2a98a67d138f2a42f472dfeb95e87c416c5c96ad
    }
  }
}