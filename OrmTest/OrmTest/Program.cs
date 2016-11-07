using SqlSugarRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单用法
            using (ISqlSugarClient db = DbRepository.GetInstance(DbType.Oracle, "server=.xxx;uid=xxx;pwd=ss;database=xxxx"))
            {
                db.SqlQuery<String>("select 1");
            }


            //强类型用法
            using (MyDbRepository db2 = new MyDbRepository())
            {
                //当前MYSQL（默认MyDbRepository第一个字段）


                db2.SetCurrent(db2.MySql2);
                //当前MYSQL2


                db2.SetCurrent(db2.SqlServer);
                //当前SqlServer


                //根据当前库获取不同的SQL
                var sql= db2.Tool.GetSql("exec sp", "call sp", "select xxx","exex oracle sp");
                db2.Database.SqlQuery<string>(sql);
            }
        }
    }

    public class MyDbRepository : DbRepository
    {

        public ConnectionConfig MySql = new ConnectionConfig() { ConnectionString = "", DbType = DbType.MySql };
        public ConnectionConfig MySql2 = new ConnectionConfig() { ConnectionString = "", DbType = DbType.MySql };
        public ConnectionConfig SqlServer = new ConnectionConfig() { ConnectionString = "", DbType = DbType.SqlServer };
        public ConnectionConfig SqlServer2 = new ConnectionConfig() { ConnectionString = "", DbType = DbType.SqlServer };

     
    }
}
