using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data;

namespace SugarForOne
{
    public partial class SqlSugarClient : ISqlSugarClient
    {
        ISqlSugarClient _db = null;
        public SqlSugarClient(DbType type, string connectionString)
        {
            switch (type)
            {
                case DbType.SqlServer:
                    _db = new SqlSugar.SqlSugarClient(connectionString);
                    break;
                case DbType.Oracle:
                    break;
                case DbType.Sqlite:
                    break;
                case DbType.MySql:
                    break;
                default:
                    break;
            }
        }

        public string ConnectionString
        {
            get
            {
                return _db.ConnectionString;
            }
        }

        public string[] DisableInsertColumns
        {
            get
            {
                return _db.DisableInsertColumns;
            }

            set
            {
                _db.DisableInsertColumns = value;
            }
        }

        public string[] DisableUpdateColumns
        {
            get
            {
                return _db.DisableUpdateColumns;
            }

            set
            {
                _db.DisableUpdateColumns = value;
            }
        }

        public void AddDisableInsertColumns(params string[] columns)
        {
            _db.AddDisableInsertColumns(columns);
        }

        public void AddDisableUpdateColumn(params string[] columns)
        {
            _db.AddDisableUpdateColumn(columns);
        }

        public void AddMappingColum(KeyValue mappingColumns)
        {
            _db.AddMappingColum(mappingColumns);
        }

        public void AddMappingTable(KeyValue mappingTable)
        {
            _db.AddMappingTable(mappingTable);
        }

        public bool Delete<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return _db.Delete(expression);
        }

        public bool Delete<T>(List<T> deleteObjList) where T : class
        {
            return _db.Delete(deleteObjList);
        }

        public bool Delete<T>(T deleteObj) where T : class
        {
            return _db.Delete(deleteObj);
        }

        public bool Delete<T>(string SqlWhereString, object whereObj = null) where T : class
        {
            return _db.Delete<T>(SqlWhereString, whereObj);
        }

        public bool Delete<T, FiledType>(params FiledType[] whereIn) where T : class
        {
            return _db.Delete(whereIn);
        }

        public bool Delete<T, FiledType>(Expression<Func<T, object>> expression, List<FiledType> whereIn) where T : class
        {
            return _db.Delete(expression, whereIn);
        }

        public bool Delete<T, FiledType>(Expression<Func<T, object>> expression, params FiledType[] whereIn) where T : class
        {
            return _db.Delete(expression, whereIn);
        }

        public bool FalseDelete<T>(string field, Expression<Func<T, bool>> expression) where T : class
        {
            return _db.FalseDelete(field, expression);
        }

        public bool FalseDelete<T, FiledType>(string field, params FiledType[] whereIn) where T : class
        {
            return _db.FalseDelete<T, FiledType>(field, whereIn);
        }

        public object Insert<T>(T entity, bool isIdentity = true) where T : class
        {
            return _db.Insert(entity, isIdentity);
        }

        public List<object> InsertRange<T>(List<T> entities, bool isIdentity = true) where T : class
        {
            return _db.InsertRange(entities, isIdentity);
        }

        public Queryable<T> Queryable<T>() where T : class, new()
        {
            return _db.Queryable<T>();
        }

        public Queryable<T> Queryable<T>(string tableName) where T : class, new()
        {
            return _db.Queryable<T>(tableName);
        }

        public void RemoveAllCache<T>()
        {
            _db.RemoveAllCache<T>();
        }

        public void SetFilterFilterParas(Dictionary<string, Func<KeyValueObj>> filterRows)
        {
            _db.SetFilterFilterParas(filterRows);
        }

        public void SetFilterFilterParas(Dictionary<string, List<string>> filterColumns)
        {
            _db.SetFilterFilterParas(filterColumns);
        }

        public void SetMappingColumns(List<KeyValue> mappingColumns)
        {
            _db.SetMappingColumns(mappingColumns);
        }

        public void SetMappingTables(List<KeyValue> mappingTables)
        {
            _db.SetMappingTables(mappingTables);
        }

        public void SetSerialNumber(List<PubModel.SerialNumber> serNum)
        {
            _db.SetSerialNumber(serNum);
        }

        public Sqlable Sqlable()
        {
            return _db.Sqlable();
        }

        public bool SqlBulkCopy<T>(List<T> entities) where T : class
        {
            return _db.SqlBulkCopy(entities);
        }

        public bool SqlBulkReplace<T>(List<T> entities) where T : class
        {
            return _db.SqlBulkReplace(entities);
        }

        public List<T> SqlQuery<T>(string sql, object whereObj = null)
        {
            return _db.SqlQuery<T>(sql, whereObj);
        }

        public List<T> SqlQuery<T>(string sql, List<SqlParameter> pars)
        {
            return _db.SqlQuery<T>(sql, pars);
        }

        public List<T> SqlQuery<T>(string sql, SqlParameter[] pars)
        {
            return _db.SqlQuery<T>(sql, pars);
        }

        public dynamic SqlQueryDynamic(string sql, object whereObj = null)
        {
            return _db.SqlQueryDynamic(sql, whereObj);
        }

        public string SqlQueryJson(string sql, object whereObj = null)
        {
            return _db.SqlQueryJson(sql, whereObj);
        }

        public bool Update<T>(T rowObj) where T : class
        {
            return _db.Update(rowObj);
        }

        public bool Update<T>(object rowObj, Expression<Func<T, bool>> expression) where T : class
        {
            return _db.Update(rowObj, expression);
        }

        public bool Update<T>(string setValues, Expression<Func<T, bool>> expression, object whereObj = null) where T : class
        {
            return _db.Update(setValues, expression, whereObj);
        }

        public bool Update<T, FiledType>(object rowObj, params FiledType[] whereIn) where T : class
        {
            return _db.Update<T, FiledType>(rowObj, whereIn);
        }

        public List<bool> UpdateRange<T>(List<T> rowObjList) where T : class
        {
            return _db.UpdateRange(rowObjList);
        }
    }
}
