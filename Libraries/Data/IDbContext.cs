using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public interface IDbContext<T>
  {
    
    int Add(T model);

    IEnumerable<T> FindAll(Expression<Func<T, bool>> filter);

    //  IQueryable<T> FindAll(Expression<Func<T, bool>> filter);
    T Find(Expression<Func<T, bool>> filter);

    void Update(T param);

    void Delete(T param);

    void Delete(Expression<Func<T, bool>> filter);

  }
}
