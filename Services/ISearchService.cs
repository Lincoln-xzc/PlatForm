using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public interface ISearchService<T>
  {
    T Get(Expression<Func<T, bool>> filter);

    List<T> Search(Expression<Func<T, bool>> filter);

    IPagedList<T> GetAllByPage(Expression<Func<T, bool>> filter,int pageIndex = 1, int pageSize = int.MaxValue);
  }
}
