using Core.Data;
using Core.Entities;
using platform.Filters;
using Service.Orders;
using Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Controllers
{
  public class UserController : BaseController
  {
    //private readonly IUserService _userServcie;

    // private IUserRepository _userRepository;

    private IUserService _userService;

    private IOrderService _orderService;

   // private readonly ISearchServcie _searchService; 
    public UserController(IUserService userService,IOrderService orderService)
    {
      this._userService = userService;
      this._orderService = orderService;
    }

    public ActionResult List()
    {
      IList<User> users = _userService.GetAllByPage(c=>!c.IsDel,1,10);
      return View(users);
    }

    public ActionResult Detail()
    {
      IEnumerable<Order> details = _orderService.Detial(c => !c.IsDel);
      return View(details);
    } 

  
  }
}