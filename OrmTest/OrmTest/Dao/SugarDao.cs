using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
using SqlSugarRepository;
namespace NewTest.Dao
{
    /// <summary>
    /// SqlSugar
    /// </summary>
    public class SugarDao
    {
        //禁止实例化
        private SugarDao()
        {

        }
        public static string SqlConnString = "server=.;uid=sa;pwd=sasa;database=SqlSugarTest";
        public static string MySqlConnString = "server=localhost;Database=SqlSugarTest;Uid=root;Pwd=root";
        public static string PlSqlConnString = "Data Source=localhost/orcl;User ID=system;Password=JHL52771jhl;";
        public static string SqliteSqlConnString = @"DataSource=F:\MyOpenSource\SqlSugarRepository\OrmTest\OrmTest\Database\demo.sqlite";

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ISqlSugarClient GetInstance(DbType type)
        {
            ISqlSugarClient db = null;
            switch (type)
            {
                case DbType.SqlServer:
                    db = DbRepository.GetInstance(type, SqlConnString);
                    break;
                case DbType.Sqlite:
                    db = DbRepository.GetInstance(type, SqliteSqlConnString);
                    break;
                case DbType.MySql:
                    db = DbRepository.GetInstance(type, MySqlConnString);
                    break;
                case DbType.Oracle:
                    db = DbRepository.GetInstance(type, PlSqlConnString);
                    break;
                default:
                    db = DbRepository.GetInstance(type, SqlConnString);
                    break;
            }
            db.IsEnableLogEvent = true;
            db.LogEventStarting = (sql, pars) => {
                PrintSql(sql, pars);
            };
            return db;
        }

        /// <summary>
        /// 打印Sql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pars"></param>
        private static void PrintSql(string sql, string pars)
        {
            Console.WriteLine("sql:" + sql);
            if (pars != null)
            {
                Console.WriteLine(" pars:" + pars);
            }
            Console.WriteLine("");
        }

    }
}