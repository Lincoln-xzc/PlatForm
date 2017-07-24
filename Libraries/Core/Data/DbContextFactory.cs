using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
  public class DbContextFactory
  {
    public static DbContext GetCurrentDbContext()
    {
      DbContext dbContext = CallContext.GetData("DbContext") as DbContext;

      if (dbContext == null)
      {
        dbContext = new DcPlatForm();
        CallContext.SetData("DbContext", dbContext);
      }
      return dbContext;
    }
  }
}
