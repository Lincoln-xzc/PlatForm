using System;
using System.Collections.Generic;

namespace core
{
    public interface IPagedList<T>:IList<T>
    {
        int PageIndex { get; set; }

        int PageSize { get; }

        int TotalCount { get; }

        int TotalPages { get; set; }

        bool HasPreviousPage { get; }

        bool HasNextPage { get;}
    }
}
