using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cache
{
  /// <summary>
  /// 缓存工厂实现
  /// 这样做是方便换其他的缓存时
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class ObjCacheProvider<T> : CacheProvider
  {
    public ObjCacheProvider()
    {
      SetCacheInstance(new CacheContext());
    }

    public bool Create(string key, T val, DateTime expire)
    {
      return CacheContext.Set<T>(key, val, expire);
    }

    public T GetCache(string key)
    {
      return CacheContext.Get<T>(key);
    }

    public void Remove(string key)
    {
      CacheContext.Remove(key);
    }
  }
}
