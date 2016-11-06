using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SugarForOne
{
    public class Tool
    {
        private Tool()
        {

        }
        private DbRepository _dr;
        public Tool(DbRepository dr)
        {
            _dr = dr;
        }
        public string GetSql(string SqlServerSql, string OracleSql, string SqlieSql, string MysqlSql)
        {
            if (_dr.ConnectionConfig == null)
            {
                throw new ArgumentNullException("没有设置连接配置。");
            }
            DbType type = _dr.ConnectionConfig.DbType;
            switch (type)
            {
                case DbType.SqlServer:
                    return SqlServerSql;
                case DbType.Sqlite:
                    return SqlieSql; ;
                case DbType.MySql:
                    return MysqlSql; ;
                default:
                    return OracleSql; ;
            }
        }

    }
}
