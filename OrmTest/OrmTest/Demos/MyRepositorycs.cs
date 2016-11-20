using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugarRepository;
using NewTest.Dao;

namespace NewTest.Demos
{
    public class MyRepository:DbRepository
    {
        public ConnectionConfig SqlConn1 = new ConnectionConfig() { DbType = DbType.SqlServer, ConnectionString = SugarDao.SqlConnString };
        public ConnectionConfig MySqlConn1 = new ConnectionConfig() { DbType = DbType.MySql, ConnectionString = SugarDao.MySqlConnString };
    }
}
