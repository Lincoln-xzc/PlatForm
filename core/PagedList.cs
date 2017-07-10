using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace core
{
    public class PagedList<T> : List<T>, IPagedList<T>
    {
        public int PageIndex { get; set; }

        public int PageSize { get; }

        public int TotalCount { get; }

        public int TotalPages { get; set;}

        public bool HasPreviousPage { get { return (PageIndex > 0);}}

        public bool HasNextPage { get { return (PageIndex + 1 < TotalPages); } }

        public PagedList(IQueryable<T> source, int  pageIndex, int pageSize)
        {
            int total = source.Count();
            this.TotalCount = total;
            this.TotalPages = total / pageSize;
            if (total % pageSize > 0)
                TotalPages++;
            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageSize * pageIndex).Take(pageSize).ToList());
        }

        public PagedList(IList<T> source, int pageIndex, int pageSize){
            int total = source.Count();
            this.TotalCount = total;
            this.TotalPages = total / pageSize;
            if (total % pageSize > 0)
                TotalPages++;
            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageSize * pageIndex).Take(pageSize).ToList());
        }

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize){
            int total = source.Count();
            this.TotalCount = total;
            this.TotalPages = TotalCount / pageSize;
            if (total % pageSize > 0)
                TotalPages++;
            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageSize * pageIndex).Take(pageSize).ToList());
        }

    }
}
