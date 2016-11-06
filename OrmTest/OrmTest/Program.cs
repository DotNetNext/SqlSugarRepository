using SugarForOne;
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
            var x = DbRepository.GetInstance(DbType.Oracle,"aa");
        }
    }
}
