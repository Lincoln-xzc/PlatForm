using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public interface IDbContext
  {
    IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

    int SaveChanges();

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="commandText"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    IList<TEntity> ExecuteStoredProcudureList<TEntity>(string commandText, params object[] parameters);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    /// <param name="sql"></param>
    /// <param name="paramters"></param>
    /// <returns></returns>
    IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] paramters);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="doNotEnsureTransaction"></param>
    /// <param name="timeout"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    void Detach(object entity);

    /// <summary>
    /// 
    /// </summary>
    bool ProxyCreationEnabled { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool AutoDetectChangesEnabled { get; set; }
  }
}
