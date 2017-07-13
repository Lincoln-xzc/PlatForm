using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Data;

namespace Services
{
  public class SearchService<T> : ISearchService<T>
  {

    public T Get(Expression<Func<T, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IPagedList<T> GetAllByPage(Expression<Func<T, bool>> filter, int pageIndex = 1, int pageSize = int.MaxValue)
    {
      throw new NotImplementedException();
    }

    public List<T> Search(Expression<Func<T, bool>> filter)
    {
      throw new NotImplementedException();
    }
  }
}
