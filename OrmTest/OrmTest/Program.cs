using NewTest.Demos;
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
 

            //设置执行的DEMO
            string switchOn = "insert";
            //数据库类型
            DbType type = DbType.SqlServer;
            switch (switchOn)
            {
                /****************************基本功能**************************************/
                //查询
                case "select": new Select().Init(type); break;
                case "insert": new Insert().Init(type); break;
                case "insertorupdate": new InsertOrUpdate().Init(type); break;
            }
            Console.WriteLine("执行成功请关闭窗口");
            Console.ReadKey();
        }
    }

}
