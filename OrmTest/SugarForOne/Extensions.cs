using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SugarForOne
{
    public static class Extensions
    {
        public static MySqlParameter[] ToMySqlPars(this SqlParameter[] pars)
        {
            if (pars == null) {
                return null;
            }
            List<MySqlParameter> reval = new List<MySqlParameter>();
            foreach (var item in pars)
            {
                reval.Add(item.ToMySqlPars());
            }
            return reval.ToArray();
        }
        public static MySqlParameter ToMySqlPars(this SqlParameter par)
        {
            return new MySqlParameter() { ParameterName = par.ParameterName, Value = par.Value };
        }
    }
}
