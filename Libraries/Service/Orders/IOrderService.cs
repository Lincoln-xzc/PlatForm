using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Orders
{
  public interface IOrderService
  {
    IList<Order> Detial(Expression<Func<Order, bool>> filter);
  }
}
