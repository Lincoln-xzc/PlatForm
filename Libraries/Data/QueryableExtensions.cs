using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public static class QueryableExtensions
  {
    public static PagedList<T> ToPagedList<T>(this IQueryable<T> query, int pageNumber, int pageSize)
    {
      return new PagedList<T>(query, pageNumber, pageSize);
    }
  }
}
