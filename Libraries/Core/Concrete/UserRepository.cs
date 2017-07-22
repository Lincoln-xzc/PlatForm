using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Data;

namespace Core.Concrete
{
  public class UserRepository : IUserRepository
  {
    private DcPlatForm context = new DcPlatForm();

    public IQueryable<User> Users
    {
      get { return context.users; }
    }
  }
}
