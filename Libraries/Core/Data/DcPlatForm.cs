using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public partial class DcPlatForm : DbContext
  {
    public DcPlatForm() : base("name=dcPlatForm")
    { }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> users { get; set; }

    public DbSet<Order> orders { get; set; }

    public DbSet<OrderItem> orderItems { get; set; }
  }
}
