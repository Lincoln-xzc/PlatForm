using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Data;

namespace Service.Orders
{
  public class OrderService : IOrderService
  {
    private IRepository<Order> _orderReposity;

    private IRepository<OrderItem> _orderItemRepository;

    public OrderService(IRepository<Order> orderReposity, IRepository<OrderItem> orderItemReposity)
    {
      this._orderReposity = orderReposity;
      this._orderItemRepository = orderItemReposity;
    }

    public IList<Order> Detial(Expression<Func<Order, bool>> filter)
    {
      return (from c in _orderReposity.Table select c).Where(filter).ToList();
    }
  }
}
