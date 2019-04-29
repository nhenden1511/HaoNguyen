using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Repository
{
    public interface IBaseRepository<T>
    {
        IList<T> GetAll(int skip = 0, int take = 0);

        int ExecuteNonQuery(string cmdText, params object[] args);

        T ExecuteScalar(string cmdText, params object[] args);

        TU ExecuteScalar<TU>(string cmdText, params object[] args);

        IList<T> ExecuteQuery(string cmdText, params object[] args);

        IList<TU> ExecuteQuery<TU>(string cmdText, params object[] args);

        int Update(T o);

        int Update<TU>(TU o);

        int UpdateAll(IList<T> o);

        int UpdateAll<TU>(IList<TU> o);

        int Insert(T o);

        int Insert<TU>(TU o);

        int InsertAll(IList<T> o);

        int InsertAll<TU>(IList<TU> o);

        int InsertOrReplace(T o);

        int InsertOrReplace<TU>(TU o);

        int InsertOrReplaceAll(IList<T> o);

        int InsertOrReplaceAll<TU>(IList<TU> o);

        int Delete(T o);

        int Delete<TU>(TU o);

        int DeleteAll();
    }
}
