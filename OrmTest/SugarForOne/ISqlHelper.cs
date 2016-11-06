using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SugarForOne
{
    public interface ISqlHelper
    {
        void BeginTran();
        void BeginTran(string transactionName);
        void BeginTran(IsolationLevel iso);
        void BeginTran(IsolationLevel iso, string transactionName);
        void CommitTran();
        void Dispose();
        int ExecuteCommand(string sql, params SqlParameter[] pars);
        int ExecuteCommand(string sql, object pars);
        SqlConnection GetConnection();
        DataSet GetDataSetAll(string sql, params SqlParameter[] pars);
        DataSet GetDataSetAll(string sql, object pars);
        DataTable GetDataTable(string sql, params SqlParameter[] pars);
        DataTable GetDataTable(string sql, object pars);
        DateTime GetDateTime(string sql, params SqlParameter[] pars);
        decimal GetDecimal(string sql, params SqlParameter[] pars);
        double GetDouble(string sql, params SqlParameter[] pars);
        int GetInt(string sql, params SqlParameter[] pars);
        int GetInt(string sql, object pars);
        List<T> GetList<T>(string sql, params SqlParameter[] pars);
        List<T> GetList<T>(string sql, object pars);
        SqlDataReader GetReader(string sql, params SqlParameter[] pars);
        SqlDataReader GetReader(string sql, object pars);
        object GetScalar(string sql, params SqlParameter[] pars);
        object GetScalar(string sql, object pars);
        T GetSingle<T>(string sql, params SqlParameter[] pars);
        T GetSingle<T>(string sql, object pars);
        string GetString(string sql, params SqlParameter[] pars);
        string GetString(string sql, object pars);
        void RollbackTran();
    }
}