using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Data
{
  public class DbContextImpl<T> where T : class, IDbContext<T>
  {

    public int Add(T model)
    {
      using(DcPlatForm db = new DcPlatForm())
      {
        db.Set<T>().Add(model);
        return db.SaveChanges();
      }
    }

    public void Update(T model)
    {
      using(DcPlatForm db = new DcPlatForm())
      {
        if(db.Entry<T>(model).State == EntityState.Detached)
        {
          db.Set<T>().Attach(model);
          db.Entry<T>(model).State = EntityState.Modified;
        }
      }
    }

    public void Delete(T model)
    {
      using (DcPlatForm db = new DcPlatForm())
      {
        db.Set<T>().Remove(model);
      }
    }

    public void Delete(Expression<Func<T,bool>> filter)
    {
      using(DcPlatForm db = new DcPlatForm())
      {
        var models = db.Set<T>().Where(filter);
        if(models != null)
        {
          foreach(var model in models)
          {
            db.Set<T>().Remove(model);
          }
        }
      }
    }

    public T Find(Expression<Func<T, bool>> filter)
    {
      using(DcPlatForm db = new DcPlatForm())
      {
        return db.Set<T>().Where(filter).FirstOrDefault();
      }
    }

    public IEnumerable<T> FindAll(Expression<Func<T, bool>> filter)
    {
      using(DcPlatForm db = new DcPlatForm())
      {
        return db.Set<T>().Where(filter).ToList();
      }
    }

    
  }
}
