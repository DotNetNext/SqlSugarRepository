using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugarRepository
{
    /// <summary>
    /// 工具扩展 
    /// </summary>
    public static class SqlbuilderExtensions
    {
        public static SqlBuilder Sqlbuilder(this ISqlSugarClient db)
        {
            return new SqlBuilder(db);
        }

        public static SqlBuilder ToSqlServer(this SqlBuilder thisValue, string sql)
        {
            thisValue.Append("[MSSQLDB]:" + sql);
            return thisValue;
        }
        public static SqlBuilder ToMySql(this SqlBuilder thisValue, string sql)
        {
            thisValue.Append("[MYSQLDB]:" + sql);
            return thisValue;
        }

        public static SqlBuilder ToOracle(this SqlBuilder thisValue, string sql)
        {
            thisValue.Append("[ORACLEDB]:" + sql);
            return thisValue;
        }

        public static SqlBuilder ToSqlite(this SqlBuilder thisValue, string sql)
        {
            thisValue.Append("[SQLITEDB]:" + sql);
            return thisValue;
        }
        public static SqlBuilder ToOther(this SqlBuilder thisValue, string sql)
        {
            thisValue.Append("[OTHERDB]:" + sql);
            return thisValue;
        }

    }
}
