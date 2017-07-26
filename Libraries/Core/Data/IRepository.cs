using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
  public partial interface IRepository<T> where T :BaseEntity
  {
    T GetById(object id);

    IQueryable<T> Filter(Expression<Func<T, bool>> filter);

    void Insert(T entity);

    void Insert(IEnumerable<T> entities);

    void BatchAdd(T[] entities);

    void Update(T entity);

    void Update(Expression<Func<T, bool>> filter, Expression<Func<T, T>> entity);

    void Delete(T eneity);

    void Delete(Expression<Func<T, bool>> filter);

    IQueryable<T> Table { get; }

    IQueryable<T> TableNoTracking { get; }

    bool IsExist(Expression<Func<T, bool>> exp);


  }
}
