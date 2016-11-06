using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SugarForOne
{
    /// <summary>
    /// 数据库服务
    /// </summary>
    public class DbRepository
    {
        /// <summary>
        /// 获取数据库连接实例
        /// </summary>
        /// <param name="type"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static ISqlSugarClient GetInstance(DbType type, string connectionString)
        {
            ISqlSugarClient db=null;
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


        public static 
    }
}
