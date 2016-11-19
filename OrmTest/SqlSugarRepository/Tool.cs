using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugarRepository
{
    /// <summary>
    /// 工具
    /// </summary>
    public class Tool
    {
        private Tool()
        {

        }
        private DbRepository _dr;
        /// <summary>
        /// 工具
        /// </summary>
        /// <param name="dr"></param>
        public Tool(DbRepository dr)
        {
            _dr = dr;
        }
        /// <summary>
        /// 获取SQL
        /// </summary>
        /// <param name="SqlServerSql"></param>
        /// <param name="OracleSql"></param>
        /// <param name="SqlieSql"></param>
        /// <param name="MysqlSql"></param>
        /// <returns></returns>
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
