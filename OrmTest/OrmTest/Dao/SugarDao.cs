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
        private static string SqlConnString = "server=.;uid=sa;pwd=sasa;database=SqlSugarTest";
        private static string MySqlConnString = "server=localhost;Database=SqlSugarTest;Uid=root;Pwd=root";
        private static string PlSqlConnString = "Data Source=localhost/orcl;User ID=system;Password=JHL52771jhl;";
        private static string SqliteSqlConnString = @"DataSource=F:\MyOpenSource\SqlSugarRepository\OrmTest\OrmTest\Database\demo.sqlite";


        public static ISqlSugarClient GetInstance(DbType type)
        {

            if (type == DbType.SqlServer) return GetSqlServerInstance();
            if (type == DbType.Oracle) return GetOracleInstance();
            if (type == DbType.MySql) return GetMyInstance();
            if (type == DbType.Sqlite) return GetSqliteInstance();
            return null;
        }

        public static ISqlSugarClient GetSqlServerInstance()
        {
            var dbType = DbType.SqlServer;
            var db = DbRepository.GetInstance(dbType, SqlConnString);//可以切换成其它数据库
            Console.WriteLine("启动" + dbType.ToString());
            return db;
        }
        public static ISqlSugarClient GetMyInstance()
        {
            var dbType = DbType.MySql;
            var db = DbRepository.GetInstance(dbType, MySqlConnString);//可以切换成其它数据库
            Console.WriteLine("启动" + dbType.ToString());
            return db;
        }
        public static ISqlSugarClient GetOracleInstance()
        {
            var dbType = DbType.Oracle;
            var db = DbRepository.GetInstance(dbType, PlSqlConnString);//可以切换成其它数据库
            Console.WriteLine("启动" + dbType.ToString());
            return db;
        }
        public static ISqlSugarClient GetSqliteInstance()
        {
            var dbType = DbType.Sqlite;
            var db = DbRepository.GetInstance(dbType, SqliteSqlConnString);//可以切换成其它数据库
            Console.WriteLine("启动" + dbType.ToString());
            return db;
        }
    }
}