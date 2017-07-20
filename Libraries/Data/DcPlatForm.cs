using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public partial class DcPlatForm : DbContext
  {
    public DcPlatForm() : base("name=dbPlatForm")
    {

    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<User> user { get; set; }
  }
}
