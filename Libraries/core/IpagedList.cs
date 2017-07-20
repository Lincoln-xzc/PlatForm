using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public interface IPagedList<T>:IList<T>
  {
    int PageIndex { get; set; }

    int PageSize { get;  }

    int TotalCount { get;  }

    int TotalPages { get; set; }

    bool HasPreviousPage { get; }
    
    bool HasNextPage { get; }
  }
}
