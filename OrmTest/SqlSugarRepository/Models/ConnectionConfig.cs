using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugarRepository
{
    public class ConnectionConfig
    {
        public Guid UniqueKey = Guid.NewGuid();
        public string ConnectionString { get; set; }
        public DbType DbType { get; set; }
    }
}
