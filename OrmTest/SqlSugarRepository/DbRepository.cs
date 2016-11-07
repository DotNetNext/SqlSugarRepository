using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SqlSugarRepository
{
    /// <summary>
    /// 数据库服务
    /// </summary>
    public class DbRepository : IDisposable
    {

        /// <summary>
        /// 获取数据库连接实例
        /// </summary>
        /// <param name="type">数据库类型</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns></returns>
        public static ISqlSugarClient GetInstance(DbType type, string connectionString)
        {
            ISqlSugarClient db = null;
            switch (type)
            {
                case DbType.SqlServer:
                    db = new SqlSeverSugarClient(connectionString);
                    break;
                case DbType.Sqlite:
                    db = new SqliteSugarClient(connectionString);
                    break;
                case DbType.MySql:
                    db = new MySqlSugarClient(connectionString);
                    break;
                case DbType.Oracle:
                    db = new PlSqlSugarClient(connectionString);
                    break;
            }
            return db;
        }

        /// <summary>
        /// 获取数据库连接实例
        /// </summary>
        /// <param name="type">数据库类型</param>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns></returns>
        public ISqlSugarClient Database
        {
            get
            {
                var isInit = _dbs == null;
                if (isInit) {


                }
                return _currentClient;
            }
        }

        /// <summary>
        /// 工具类
        /// </summary>
        public Tool Tool
        {
            get
            {
                return new Tool(this);
            }
        }


        private List<ISqlSugarClient> _dbs = null;
        private ISqlSugarClient _currentClient = null;
        internal ConnectionConfig ConnectionConfig = null;

        public DbRepository()
        {

        }

        /// <summary>
        /// 设置当前连接池
        /// </summary>
        /// <param name="config"></param>
        public void SetCurrent(ConnectionConfig config)
        {
            ISqlSugarClient db = null;
            switch (config.DbType)
            {
                case DbType.SqlServer:
                    db = new SqlSeverSugarClient(config.ConnectionString);
                    break;
                case DbType.Sqlite:
                    db = new SqliteSugarClient(config.ConnectionString);
                    break;
                case DbType.MySql:
                    db = new MySqlSugarClient(config.ConnectionString);
                    break;
                case DbType.Oracle:
                    db = new PlSqlSugarClient(config.ConnectionString);
                    break;
            }
            var isFirstDb = _dbs == null || _dbs.Count == 0;
            if (isFirstDb)
            {
                _dbs.Add(db);
            }
            else
            {
                var currentDb = _dbs.SingleOrDefault(it => it.ConnectionUniqueKey == config.UniqueKey);
                if (db != null)
                {
                    _currentClient = currentDb;
                }
                else
                {
                    throw new Exception("");
                }

            }
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            if (_dbs != null && _dbs.Count > 0)
            {
                foreach (var item in _dbs)
                {
                    item.Dispose();
                }
            }
        }
    }
}
