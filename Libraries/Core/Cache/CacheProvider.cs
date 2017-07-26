using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cache
{
  public abstract class CacheProvider : IDisposable
  {

    public ICacheContext CacheContext { get; private set; }

    public void SetCacheInstance(ICacheContext cacheContext)
    {
      if(CacheContext != null)
      {
        CacheContext = null;
      }

      CacheContext = cacheContext;
    }

    public void SetCacheInstance(Type cacheContextType)
    {
      if(cacheContextType == null)
      {
        throw new ArgumentException("cacheContextType");
      }

      if (!typeof(ICacheContext).IsAssignableFrom(cacheContextType))
      {
        throw new ArgumentException(
          string.Format(CultureInfo.CurrentCulture, "该类型{0}必须继承自抽象类CacheContext", cacheContextType),
          "cacheContextType");
      }

      try
      {
        CacheContext = Activator.CreateInstance(cacheContextType) as ICacheContext;
      }
      catch (Exception ex)
      {
        throw new InvalidOperationException(
          String.Format(
            CultureInfo.CurrentCulture,
            "创建抽象类CacheContext 的实列{0}失败",
            cacheContextType), ex);
      }
    }

    public void Dispose()
    {
      
    }
  }
}
