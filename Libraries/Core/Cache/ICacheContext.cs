using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Cache
{
  /// <summary>
  /// 缓存接口
  /// </summary>
  public abstract class ICacheContext
  {

    /// <summary>
    /// 获取缓存项
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <returns></returns>
    public abstract T Get<T>(string key);

    public abstract bool Set<T>(string key, T t, DateTime expire);

    public abstract bool Remove(string key);
  }
}
