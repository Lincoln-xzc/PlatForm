using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Users
{
  public interface IUserService
  {
    void InsertUser(User user);

    void UpdateUser(User user);

    User GetById(Object id);

    void DeleteUser(User user);

    void DeleteById(Object id);

    List<User> Search(Expression<Func<User, bool>> filter);

    User CheckLogin(string mobile,string password);

    IPagedList<User> GetAllByPage(Expression<Func<User, bool>> filter, int pageIndex = 1, int pageSize =10);

    User Register(User user);
  }
}
