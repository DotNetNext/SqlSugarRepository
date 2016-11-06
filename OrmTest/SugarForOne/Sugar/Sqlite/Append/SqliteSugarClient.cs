using SQLiteSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data;

namespace SugarForOne
{
    internal partial class SqliteSugarClient : ISqlSugarClient, IDisposable
    {
        SqlSugarClient _db = null;
        public SqliteSugarClient(string connectionString)
        {
            _db = new SqlSugarClient(connectionString);
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
            _db.AddMappingColum(new SQLiteSugar.KeyValue() { Key = mappingColumns.Key, Value = mappingColumns.Value });
        }

        public void AddMappingTable(KeyValue mappingTable)
        {
            _db.AddMappingTable(new SQLiteSugar.KeyValue() { Key = mappingTable.Key, Value = mappingTable.Value });
        }

        public void BeginTran()
        {
            _db.BeginTran();
        }

        public void BeginTran(string transactionName)
        {
            throw new MulticastNotSupportedException();
        }

        public void CommitTran()
        {
            _db.CommitTran();
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

        public void Dispose()
        {
            _db.Dispose();
        }

        public int ExecuteCommand(string sql, object pars)
        {
            return _db.ExecuteCommand(sql, pars);
        }

        public int ExecuteCommand(string sql, params SqlParameter[] pars)
        {
            return _db.ExecuteCommand(sql, pars);
        }

        public bool FalseDelete<T>(string field, Expression<Func<T, bool>> expression) where T : class
        {
            return _db.FalseDelete(field, expression);
        }

        public bool FalseDelete<T, FiledType>(string field, params FiledType[] whereIn) where T : class
        {
            return _db.FalseDelete<T, FiledType>(field, whereIn);
        }

        public DataSet GetDataSetAll(string sql, object pars)
        {
            return _db.GetDataSetAll(sql, pars);
        }

        public DataSet GetDataSetAll(string sql, params SqlParameter[] pars)
        {
            return _db.GetDataSetAll(sql, pars.ToSqlitePars());
        }

        public DataTable GetDataTable(string sql, object pars)
        {
            return _db.GetDataTable(sql, pars);
        }

        public DataTable GetDataTable(string sql, params SqlParameter[] pars)
        {
            return _db.GetDataTable(sql, pars.ToSqlitePars());
        }

        public DateTime GetDateTime(string sql, params SqlParameter[] pars)
        {
            return _db.GetDateTime(sql, pars.ToSqlitePars());
        }

        public decimal GetDecimal(string sql, params SqlParameter[] pars)
        {
            return _db.GetDecimal(sql, pars.ToSqlitePars());
        }

        public double GetDouble(string sql, params SqlParameter[] pars)
        {
            return _db.GetDouble(sql, pars.ToSqlitePars());
        }

        public int GetInt(string sql, object pars)
        {
            return _db.GetInt(sql, pars);
        }

        public int GetInt(string sql, params SqlParameter[] pars)
        {
            return _db.GetInt(sql, pars.ToSqlitePars());
        }

        public List<T> GetList<T>(string sql, object pars)
        {
            return _db.GetList<T>(sql, pars);
        }

        public List<T> GetList<T>(string sql, params SqlParameter[] pars)
        {
            return _db.GetList<T>(sql, pars.ToSqlitePars());
        }

        public object GetScalar(string sql, object pars)
        {
            return _db.GetScalar(sql, pars);
        }

        public object GetScalar(string sql, params SqlParameter[] pars)
        {
            return _db.GetScalar(sql, pars.ToSqlitePars());
        }

        public T GetSingle<T>(string sql, object pars)
        {
            return _db.GetSingle<T>(sql, pars);
        }

        public T GetSingle<T>(string sql, params SqlParameter[] pars)
        {
            return _db.GetSingle<T>(sql, pars.ToSqlitePars());
        }

        public string GetString(string sql, object pars)
        {
            return _db.GetString(sql, pars);
        }

        public string GetString(string sql, params SqlParameter[] pars)
        {
            return _db.GetString(sql, pars.ToSqlitePars());
        }

        public object Insert<T>(T entity, bool isIdentity = true) where T : class
        {
            return _db.Insert(entity, isIdentity);
        }

        public List<object> InsertRange<T>(List<T> entities, bool isIdentity = true) where T : class
        {
            return _db.InsertRange(entities, isIdentity);
        }

        //public Queryable<T> Queryable<T>() where T : class, new()
        //{
        //    return _db.Queryable<T>();
        //}

        //public Queryable<T> Queryable<T>(string tableName) where T : class, new()
        //{
        //    return _db.Queryable<T>(tableName);
        //}

        public void RemoveAllCache<T>()
        {
            _db.RemoveAllCache<T>();
        }

        public void RollbackTran()
        {
            _db.RollbackTran();
        }

        public void SetFilterFilterParas(Dictionary<string, Func<KeyValueObj>> filterRows)
        {
            Dictionary<string, Func<SQLiteSugar.KeyValueObj>> values = new Dictionary<string, Func<SQLiteSugar.KeyValueObj>>();
            foreach (var item in filterRows)
            {
                values.Add(item.Key, () =>
                {
                    var value = item.Value();
                    return new SQLiteSugar.KeyValueObj()
                    {
                        Key = value.Key,
                        Value = value.Value
                    };
                });
            }
            _db.SetFilterFilterParas(values);
        }

        public void SetFilterFilterParas(Dictionary<string, List<string>> filterColumns)
        {
            _db.SetFilterFilterParas(filterColumns);
        }

        public void SetMappingColumns(List<KeyValue> mappingColumns)
        {
            _db.SetMappingColumns(mappingColumns.Select(it => new SQLiteSugar.KeyValue() { Key = it.Key, Value = it.Value }).ToList());
        }

        public void SetMappingTables(List<KeyValue> mappingTables)
        {
            _db.SetMappingTables(mappingTables.Select(it => new SQLiteSugar.KeyValue() { Key = it.Key, Value = it.Value }).ToList());
        }

        public void SetSerialNumber(List<SerialNumber> serNum)
        {
            var values = new List<SQLiteSugar.PubModel.SerialNumber>();
            foreach (var item in serNum)
            {
                var value = new SQLiteSugar.PubModel.SerialNumber()
                {
                    FieldName = item.FieldName,
                    TableName = item.TableName,
                    GetNumFunc = item.GetNumFunc,
                };
                if (value.GetNumFuncWithDb != null) {
                    value.GetNumFunc = ()=> {
                        return item.GetNumFuncWithDb(this);
                    };
                }
            }
            _db.SetSerialNumber(values);
        }

        //public Sqlable Sqlable()
        //{
        //    return _db.Sqlable();
        //}

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
            return _db.SqlQuery<T>(sql, pars.ToArray().ToMySqlPars());
        }

        public List<T> SqlQuery<T>(string sql, SqlParameter[] pars)
        {
            return _db.SqlQuery<T>(sql, pars.ToSqlitePars());
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
