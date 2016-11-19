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
            string switchOn = "delete";
            //数据库类型
            DbType type = DbType.Sqlite;
            //用到oracle才需要设置
            SetSeq();

            switch (switchOn)
            {
                /****************************基本功能**************************************/
                //查询
                case "select": new Select().Init(type); break;
                //插入
                case "insert": new Insert().Init(type); break;
                //更新或插入
                case "insertorupdate": new InsertOrUpdate().Init(type); break;
                //插入
                case "update": new Update().Init(type); break;
                //删除
                case "delete": new Delete().Init(type); break;
                //别名表
                case "mappingtable": new MappingTable().Init(type); break;
                //别名列
                case "mappingcolumns": new MappingColumns().Init(type); break;
                //属性方式添加别名
                case "attributesmapping": new AttributesMapping().Init(type); break;
                //事务
                case "tran": new Tran().Init(type); break;
            }
            Console.WriteLine("执行成功请关闭窗口,更多例方请查看官网 www.codeisbug.com");
            Console.ReadKey();
        }

        private static void SetSeq()
        {
            //设置Oracle序列
            OracleSugar.OracleConfig.SequenceMapping = new List<OracleSugar.SequenceModel>() {
                new OracleSugar.SequenceModel() { TableName="student", ColumnName="id", Value="seq" }};
        }
    }

}
