using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
  public partial interface IRepository<T> where T : BaseEntity
  {
    T GetById(object id);

    void Insert(T entity);

    void Insert(IEnumerable<T> entities);

    void Update(T entity);

    void Update(IEnumerable<T> entities);

    void Delete(T eneity);

    void Delete(IEnumerable<T> entities);

    IQueryable<T> Table { get; }

    IQueryable<T> TableNoTracking { get; }


  }
}
