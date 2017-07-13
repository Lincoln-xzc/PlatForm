using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Entities.User;
using Core.Data;
using Data;

namespace Services.Users
{
  public class UserService : IUserService
  {

    public readonly IRepository<User> _userReposity;

    public UserService(IRepository<User> userReposity)
    {
      this._userReposity = userReposity;
    }

    public void DeleteById(object Id)
    {
      User user = GetById(Id);
      if (user != null)
        _userReposity.Delete(user);
    }

    public void DeleteUser(User user)
    {
      if (user != null)
        _userReposity.Delete(user);
    }

    public User GetByCondition(Expression<Func<User, bool>> filter)
    {
      return _userReposity.Table.Where(filter).FirstOrDefault();
    }

    public IPagedList<User> GetAllByPage(Expression<Func<User, bool>> filter, int pageIndex = 1, int pageSize = int.MaxValue)
    {
      return _userReposity.Table.Where(filter).ToPagedList(pageIndex,pageSize);
    }

    public User GetById(Object Id)
    {
      return _userReposity.GetById(Id);
    }

    public void InsertUser(User user)
    {
      if(user !=null)
       _userReposity.Insert(user);
    }

    public List<User> Search(Expression<Func<User, bool>> filter)
    {
      return _userReposity.Table.Where(filter).ToList();
    }

    public virtual void UpdateUser(User user)
    {
      if (user == null)
        throw new ArgumentNullException("customer");

       _userReposity.Update(user);
    }
  }
}
