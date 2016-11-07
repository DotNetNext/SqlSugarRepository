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
            using (ISqlSugarClient db = DbRepository.GetInstance(DbType.SqlServer, "server=.;uid=sa;pwd=sasa;database=SqlSugarTest"))
            {
               var x= db.SqlQuery<String>("select 1");
            }


            //强类型用法
            using (MyDbRepository db2 = new MyDbRepository())
            {
                db2.Database.SqlQuery<string>("select 1");
        


                //db2.SetCurrent(db2.MySql2);
                //当前MYSQL2


                db2.SetCurrent(db2.SqlServer);
                //当前SqlServer


                //根据当前库获取不同的SQL
                var sql= db2.Tool.GetSql("exec sp", "call sp", "select xxx","exex oracle sp");
            
            }

            //强类型用法
            using (MyDbRepository db3 = new MyDbRepository())
            {
                db3.Database.SqlQuery<string>("select 1");



                //db2.SetCurrent(db2.MySql2);
                //当前MYSQL2


                db3.SetCurrent(db3.SqlServer);
                //当前SqlServer


                //根据当前库获取不同的SQL
                var sql = db3.Tool.GetSql("exec sp", "call sp", "select xxx", "exex oracle sp");

            }
        }
    }

    public class MyDbRepository : DbRepository
    {
        public ConnectionConfig SqlServer = new ConnectionConfig() { ConnectionString = "server=.;uid=sa;pwd=sasa;database=SqlSugarTest", DbType = DbType.SqlServer };
        //public ConnectionConfig MySql = new ConnectionConfig() { ConnectionString = "", DbType = DbType.MySql };
        //public ConnectionConfig MySql2 = new ConnectionConfig() { ConnectionString = "", DbType = DbType.MySql };
        public ConnectionConfig SqlServer2 = new ConnectionConfig() { ConnectionString = "server=.;uid=sa;pwd=sasa;database=SqlSugarTest", DbType = DbType.SqlServer };

     
    }
}
