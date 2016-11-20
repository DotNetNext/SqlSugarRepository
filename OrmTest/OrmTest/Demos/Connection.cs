using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugarRepository;
using NewTest.Dao;

namespace NewTest.Demos
{
    public class Connection
    {
        public void Init()
        {

            //普通连接
            using (ISqlSugarClient idb = MyRepository.GetInstance(DbType.MySql, SugarDao.MySqlConnString))
            {

                var list = idb.Queryable<Student>().First();

            }


            //使用MyRepositorycs连接数据库
            using (MyRepository db = new MyRepository())
            {
                //当前连接的sqlconn1
                var list = db.Database.Queryable<Student>().First();

                //切换mysql
                db.SetCurrent(db.MySqlConn1);
                var list2 = db.Database.Queryable<Student>().First(); ;

            }
        }
    }
}
