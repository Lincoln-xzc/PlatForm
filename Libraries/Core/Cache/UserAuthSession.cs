using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cache
{
  public class UserAuthSession
  {
    public string Token { get; set; }

    public string AppKey { get; set; }

    public string UserName { get; set; }

    public string IpAddress { get; set; }

    public DateTime CreateTime {get;set;}
  }
}
