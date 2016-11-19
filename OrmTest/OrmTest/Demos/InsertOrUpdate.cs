using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewTest.Dao;
using Models;
using System.Data.SqlClient;
using SqlSugar;
using SqlSugarRepository;

namespace NewTest.Demos
{
    //插入
    public class InsertOrUpdate 
    {

        public void Init(DbType type)
        {
            Console.WriteLine("启动Inset.Init");
            using (var db = SugarDao.GetInstance(type))
            {

                db.InsertOrUpdate(GetInsertItem1());//执行插入

                db.InsertOrUpdate(GetInsertItem2());//执行更新
            }
        }

        private static Student GetInsertItem1()
        {
            Student s = new Student()
            {
                name = "张" + new Random().Next(1, int.MaxValue)
            };
            return s;
        }
        private static Student GetInsertItem2()
        {
            Student s = new Student()
            {
                id=14,
                name = "张" + new Random().Next(1, int.MaxValue)
            };
            return s;
        }
    }
}
