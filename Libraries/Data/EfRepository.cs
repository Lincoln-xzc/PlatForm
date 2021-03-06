﻿using Core;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using EntityFramework.Extensions;

namespace Data
{
  public partial class EfRepository<T> : IRepository<T> where T :BaseEntity
  {

    private DcPlatForm context = new DcPlatForm();
    private IDbSet<T> _entities;

    protected string GetFullErrorText(DbEntityValidationException exc)
    {
      var msg = string.Empty;
      foreach (var validationErros in exc.EntityValidationErrors)
        foreach (var error in validationErros.ValidationErrors)
          msg += string.Format("Property: {0} Error: {1}", error.PropertyName, error.ErrorMessage) + Environment.NewLine;
      return msg;
    }

    public IQueryable<T> Table
    {
      get
      {
        return this.Entities;
      }
    }

    protected virtual IDbSet<T> Entities
    {
      get
      {
        if (_entities == null)
          _entities = context.Set<T>();
        return _entities;
      }
    }

    public IQueryable<T> TableNoTracking
    {
      get
      {
        return this.Entities.AsNoTracking();
      }
    }

    public void Delete(T entity)
    {
      this.Entities.Remove(entity);
    }

    public void Delete(IEnumerable<T> entities)
    {
      try
      {
        if (entities == null)
          throw new ArgumentNullException("entities");

        foreach (var entity in entities)
          this.Entities.Remove(entity);

        this.context.SaveChanges();

      }
      catch (DbEntityValidationException dbEx)
      {
        throw new Exception(GetFullErrorText(dbEx), dbEx);
      }


    }

    public T GetById(object id)
    {
      return this.Entities.Find(id);
    }


    public void Insert(T entity)
    {
      this.Entities.Add(entity);
    }

    public void Insert(IEnumerable<T> entities)
    {
      try
      {
        if (entities == null)
          throw new ArgumentNullException("entities");

        foreach (var entity in entities)
          this.Entities.Add(entity);

        this.context.SaveChanges();
      }
      catch (DbEntityValidationException dbEx)
      {
        throw new Exception(GetFullErrorText(dbEx), dbEx);
      }
    }

    public virtual void Update(T entity)
    {
      try
      {
        if (entity == null)
          throw new ArgumentNullException("entity");

        this.context.SaveChanges();

      }
      catch (DbEntityValidationException dbEx)
      {
        throw new Exception(GetFullErrorText(dbEx), dbEx);
      }
    }

    public virtual void Update(IEnumerable<T> entities)
    {
      try
      {
        if (entities == null)
          throw new ArgumentNullException("entities");

        this.context.SaveChanges();

      }
      catch (DbEntityValidationException dbEx)
      {
        throw new Exception(GetFullErrorText(dbEx), dbEx);
      }
    }

    public IQueryable<T> Filter(Expression<Func<T, bool>> filter)
    {
      var dbSet = this.Entities.AsQueryable();
      if(filter !=null)
        dbSet = this.Entities.Where(filter);
      return dbSet;
    }

    public void BatchAdd(T[] entities)
    {
      context.Set<T>().AddRange(entities);
      this.context.SaveChanges();
    }

    public void Delete(Expression<Func<T, bool>> filter)
    {
      this.Entities.Where(filter).Delete();
    }

    public bool IsExist(Expression<Func<T, bool>> exp)
    {
      return this.Entities.Any(exp);
    }

    public void Update(Expression<Func<T, bool>> filter, Expression<Func<T, T>> entity)
    {
      this.Entities.Where(filter).Update(entity);
    }
  }
}
