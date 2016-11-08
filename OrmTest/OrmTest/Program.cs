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
            string switchOn = "select";
            switch (switchOn)
            {
                /****************************基本功能**************************************/
                //查询
                case "select": new Select().Init(); break;
            }
            Console.WriteLine("执行成功请关闭窗口");
            Console.ReadKey();
        }
    }

}
