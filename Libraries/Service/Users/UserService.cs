using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Entities;
using Core.Data;
using Data;
using Core.Cache;
using System.Web;

namespace Service.Users
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

    public IPagedList<User> GetAllByPage(Expression<Func<User, bool>> filter, int pageIndex, int pageSize)
    {
      return _userReposity.Table.Where(filter).OrderBy(c=>c.CreatedAt).ToPagedList(pageIndex, pageSize);
    }

    public User GetById(Object Id)
    {
      return _userReposity.GetById(Id);
    }

    public void InsertUser(User user)
    {
      if (user != null)
        _userReposity.Insert(user);
    }

    public List<User> Search(Expression<Func<User, bool>> filter)
    {
      return _userReposity.Table.Where(filter).ToList();
    }

    public virtual void UpdateUser(User user)
    {
      if (user == null)
        throw new ArgumentNullException("User");

      _userReposity.Update(user);
    }

    public User CheckLogin(string mobile, string password)
    {
      if (string.IsNullOrEmpty(mobile))
        throw new ArgumentException("账号不能为空");
      if (string.IsNullOrEmpty(password))
        throw new ArgumentException("密码不能为空");
      string md5Password = MD5Encryption.GetMd5Hash(password);
      User user = _userReposity.Filter(c => c.Mobile == mobile && c.Password == md5Password && !c.IsDel).FirstOrDefault();
      if (user == null)
        throw new ArgumentException("用户不存在或者删除");
      UserAuthSession currentSession = new UserAuthSession()
      {
         UserName = user.Name,
         Token = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
         CreateTime = DateTime.Now,
         IpAddress = HttpContext.Current.Request.UserHostAddress
      };

      new ObjCacheProvider<UserAuthSession>().Create(currentSession.Token, currentSession, DateTime.Now.AddDays(2));
      return user;
    }

    public User Register(User user)
    {
      if (string.IsNullOrEmpty(user.Mobile))
        throw new ArgumentException("电话号码不能为空");
      if (string.IsNullOrEmpty(user.Password))
        throw new ArgumentException("密码不能为空");

      user.ID = Guid.NewGuid();
      user.BusinessID = new Guid();
      user.Password = MD5Encryption.GetMd5Hash(user.Password);
      user.CreatedAt = DateTime.Now;
      user.CreatedBy = user.ID;

      _userReposity.Insert(user);

      UserAuthSession currentSession = new UserAuthSession()
      {
        UserName = user.Name,
        Token = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
        CreateTime = DateTime.Now,
        IpAddress = HttpContext.Current.Request.UserHostAddress
      };
      new ObjCacheProvider<UserAuthSession>().Create(currentSession.Token, currentSession, DateTime.Now.AddDays(2));

      return user;
    }
  }
}
