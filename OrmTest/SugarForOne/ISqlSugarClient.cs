using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace SqlSugar
{
    public interface ISqlSugarClient
    {
        string ConnectionString { get; }
        string[] DisableInsertColumns { get; set; }
        string[] DisableUpdateColumns { get; set; }
        void AddDisableInsertColumns(params string[] columns);
        void AddDisableUpdateColumn(params string[] columns);
        void AddMappingColum(KeyValue mappingColumns);
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
        Queryable<T> Queryable<T>() where T : class, new();
        Queryable<T> Queryable<T>(string tableName) where T : class, new();
        void RemoveAllCache<T>();
        void SetFilterFilterParas(Dictionary<string, List<string>> filterColumns);
        void SetFilterFilterParas(Dictionary<string, Func<KeyValueObj>> filterRows);
        void SetMappingColumns(List<KeyValue> mappingColumns);
        void SetMappingTables(List<KeyValue> mappingTables);
        void SetSerialNumber(List<PubModel.SerialNumber> serNum);
        Sqlable Sqlable();
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
    }
}