using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
  public partial class DcPlatForm : DbContext
  {
    public DcPlatForm() : base("name=dbPlatForm")
    {
    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      throw new UnintentionalCodeFirstException();
    }

    public DbSet<User> user { get; set; }
  }
}
