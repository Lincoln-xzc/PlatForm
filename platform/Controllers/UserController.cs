using Core.Abstract;
using Core.Entities;
using platform.Filters;
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
    //private readonly IUserService _userServcie;

    private IUserRepository _userRepository;

   // private readonly ISearchServcie _searchService; 
    public UserController(IUserRepository userRepository)
    {
      this._userRepository = userRepository;
    }

    public ActionResult List()
    {
      List<User> users = _userRepository.Users.ToList();
      return View(users);
    }

    [RangeException]
    public string Detail(int id)
    {
      if (id > 100)
        return String.Format("The id value is : {0}", id);
      else
        throw new ArgumentOutOfRangeException("id", id, "");
    }
  }
}