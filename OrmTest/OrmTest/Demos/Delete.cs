using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewTest.Dao;
using Models;
using System.Data.SqlClient;
using SqlSugarRepository;

namespace NewTest.Demos
{
    //删除的例子
    public class Delete
    {

        public void Init(DbType type)
        {
            Console.WriteLine("启动Deletes.Init");
            using (var db = SugarDao.GetInstance(type))
            {


                //删除根据主键
                db.Delete<School, int>(10);

                //删除根据表达示
                db.Delete<School>(it => it.id > 100);//支持it=>array.contains(it.id)
 
                //主键批量删除
                db.Delete<School, string>(new string[] { "100", "101", "102" });

                //非主键批量删除
                db.Delete<School, string>(it => it.name, new string[] { "" });
                db.Delete<School, int>(it => it.id, new int[] { 20, 22 });


                //根据实体赋值实体一定要有主键，并且要有值。
                db.Delete(new School() { id = 200 });

                //根据字符串删除
                db.Delete<School>("id=:id", new { id = 100 });

                //假删除
                //db.FalseDelete<school>("is_del", 100);
                //等同于 update school set is_del=1 where id in(100)
                //db.FalseDelete<school>("is_del", it=>it.id==100);


            }
        }
    }
}
