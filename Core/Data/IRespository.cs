using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
  public partial interface IRespository<T> where T : BaseEntity
  {
    T GetById(object id);

    void Insert(T entity);

    void Insert(IEnumerable<T> entities);

    T Update(T entity);

    T Update(IEnumerable<T> entities);

    void Delete(T eneity);

    void Delete(IEnumerable<T> entities);

    IQueryable<T> Table { get; }

    IQueryable<T> TableNoTracking { get; }


  }
}
