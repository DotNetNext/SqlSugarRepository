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
            //设置Oracle序列
            OracleSugar.OracleConfig.SequenceMapping = new List<OracleSugar.SequenceModel>() { new OracleSugar.SequenceModel() { TableName="student", ColumnName="id", Value="seq" } };

            //设置执行的DEMO
            string switchOn = "mappingcolumns";
            //数据库类型
            DbType type = DbType.Oracle;
            switch (switchOn)
            {
                /****************************基本功能**************************************/
                //查询
                case "select": new Select().Init(type); break;
                case "insert": new Insert().Init(type); break;
                case "insertorupdate": new InsertOrUpdate().Init(type); break;
                case "mappingtable": new MappingTable().Init(type); break;
                case "mappingcolumns": new MappingColumns().Init(type); break;
                case "tran": new Tran().Init(type); break;
            }
            Console.WriteLine("执行成功请关闭窗口");
            Console.ReadKey();
        }
    }

}
