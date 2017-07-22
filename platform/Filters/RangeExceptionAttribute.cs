﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace platform.Filters
{
  public class RangeExceptionAttribute : FilterAttribute, IExceptionFilter
  {
    public void OnException(ExceptionContext filterContext)
    {
      if(!filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException)
      {
        int val = (int)(((ArgumentOutOfRangeException)filterContext.Exception).ActualValue);
        filterContext.Result = new ViewResult
        {
          ViewName = "Error",
          ViewData = new ViewDataDictionary<int>(val)
        };

        filterContext.ExceptionHandled = true;
      }
    }
  }
}