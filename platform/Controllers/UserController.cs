using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Controllers
{
    public class UserController : Controller
    {
       // private readonly IUserService _userService;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}