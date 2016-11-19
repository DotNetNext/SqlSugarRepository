using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace SqlSugarRepository
{
    public interface ISqlSugarClient: IDisposable
    {
        Guid ConnectionUniqueKey { get; set; }

        #region Sugar
        string ConnectionString { get; }
        string[] DisableInsertColumns { get; set; }
        string[] DisableUpdateColumns { get; set; }
        void AddDisableInsertColumns(params string[] columns);
        void AddDisableUpdateColumns(params string[] columns);
        void AddMappingColumn(KeyValue mappingColumn);
        void AddMappingTable(KeyValue mappingTable);
        bool Delete<T>(T deleteObj) where T : class;
        bool Delete<T>(List<T> deleteObjList) where T : class;
        bool Delete<T>(Expression<Func<T, bool>> expression) where T : class;
        bool Delete<T>(string SqlWhereString, object whereObj = null) where T : class;
        bool Delete<T, FiledType>(params FiledType[] whereIn) where T : class;
        bool Delete<T, FiledType>(Expression<Func<T, object>> expression, params FiledType[] whereIn) where T : class;
        bool Delete<T, FiledType>(Expression<Func<T, object>> expression, List<FiledType> whereIn) where T : class;
        bool FalseDelete<T>(string field, Expression<Func<T, bool>> expression) where T : class;
        bool FalseDelete<T, FiledType>(string field, params FiledType[] whereIn) where T : class;
        object Insert<T>(T entity, bool isIdentity = true) where T : class;
        List<object> InsertRange<T>(List<T> entities, bool isIdentity = true) where T : class;
        ISugarQueryable<T> Queryable<T>() where T : class, new();
        ISugarQueryable<T> Queryable<T>(string tableName) where T : class, new();
        void RemoveAllCache<T>();
        void SetFilterItems(Dictionary<string, List<string>> filterColumns);
        void SetFilterItems(Dictionary<string, Func<KeyValueObj>> filterRows);
        void SetMappingColumns(List<KeyValue> mappingColumns);
        void SetMappingTables(List<KeyValue> mappingTables);
        void SetSerialNumber(List<SerialNumber> serNum);
       // Sqlable Sqlable();
        bool SqlBulkCopy<T>(List<T> entities) where T : class;
        bool SqlBulkReplace<T>(List<T> entities) where T : class;
        List<T> SqlQuery<T>(string sql, SqlParameter[] pars);
        List<T> SqlQuery<T>(string sql, List<SqlParameter> pars);
        List<T> SqlQuery<T>(string sql, object whereObj = null);
        dynamic SqlQueryDynamic(string sql, object whereObj = null);
        string SqlQueryJson(string sql, object whereObj = null);
        bool Update<T>(T rowObj) where T : class;
        bool Update<T>(object rowObj, Expression<Func<T, bool>> expression) where T : class;
        bool Update<T>(string setValues, Expression<Func<T, bool>> expression, object whereObj = null) where T : class;
        bool Update<T, FiledType>(object rowObj, params FiledType[] whereIn) where T : class;
        List<bool> UpdateRange<T>(List<T> rowObjList) where T : class;

        #endregion

        #region SqlHelper
        void BeginTran();
        void BeginTran(string transactionName);
        void CommitTran();
        int ExecuteCommand(string sql, params SqlParameter[] pars);
        int ExecuteCommand(string sql, object pars);
        DataSet GetDataSetAll(string sql, params SqlParameter[] pars);
        DataSet GetDataSetAll(string sql, object pars);
        DataTable GetDataTable(string sql, params SqlParameter[] pars);
        DataTable GetDataTable(string sql, object pars);
        DateTime GetDateTime(string sql, params SqlParameter[] pars);
        decimal GetDecimal(string sql, params SqlParameter[] pars);
        double GetDouble(string sql, params SqlParameter[] pars);
        int GetInt(string sql, params SqlParameter[] pars);
        int GetInt(string sql, object pars);
        List<T> GetList<T>(string sql, params SqlParameter[] pars);
        List<T> GetList<T>(string sql, object pars);
        //SqlDataReader GetReader(string sql, params SqlParameter[] pars);
        //SqlDataReader GetReader(string sql, object pars);
        object GetScalar(string sql, params SqlParameter[] pars);
        object GetScalar(string sql, object pars);
        T GetSingle<T>(string sql, params SqlParameter[] pars);
        T GetSingle<T>(string sql, object pars);
        string GetString(string sql, params SqlParameter[] pars);
        string GetString(string sql, object pars);
        void RollbackTran(); 
        #endregion
    }
}