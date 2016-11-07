using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugarRepository
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
            Check.Exception(_dr._currentConfig == null, InternalConst.ConnectionMessageNoConfig);
            DbType type = _dr._currentConfig.DbType;
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
