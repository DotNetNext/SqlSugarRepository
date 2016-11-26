using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SqlSugarRepository
{
    /// <summary>
    /// 生成实体接口
    /// </summary>
    public interface IClassGenerating
    {
        /// <summary>
        /// 创类实体文件
        /// </summary>
        /// <param name="db"></param>
        /// <param name="fileDirectory"></param>
        /// <param name="nameSpace"></param>
        /// <param name="tableOrView"></param>
        /// <param name="callBack"></param>
        /// <param name="preAction"></param>
        void CreateClassFiles(ISqlSugarClient db, string fileDirectory, string nameSpace = null, bool? tableOrView = default(bool?), Action<string> callBack = null, Action<string> preAction = null);
        /// <summary>
        /// 创建类根据表名
        /// </summary>
        /// <param name="db"></param>
        /// <param name="fileDirectory"></param>
        /// <param name="nameSpace"></param>
        /// <param name="tableNames"></param>
        void CreateClassFilesByTableNames(ISqlSugarClient db, string fileDirectory, string nameSpace, params string[] tableNames);
        /// <summary>
        /// 创建类文件根据接口
        /// </summary>
        /// <param name="db"></param>
        /// <param name="tableOrView"></param>
        /// <param name="callBack"></param>
        void CreateClassFilesInterface(ISqlSugarClient db, bool? tableOrView, Action<DataTable, string, string> callBack);
        /// <summary>
        /// 匿名对象转类
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        string DynamicToClass(object entity, string className);
        /// <summary>
        /// 遍历表格
        /// </summary>
        /// <param name="db"></param>
        /// <param name="action"></param>
        void ForeachTables(ISqlSugarClient db, Action<string> action);
        /// <summary>
        /// 获取当前库所有表名
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        List<string> GetTableNames(ISqlSugarClient db);
        /// <summary>
        /// 获取所有架构
        /// </summary>
        /// <param name="db"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        string GetTableNameWithSchema(ISqlSugarClient db, string tableName);
        /// <summary>
        /// sqll语句生成类字符串
        /// </summary>
        /// <param name="db"></param>
        /// <param name="sql"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        string SqlToClass(ISqlSugarClient db, string sql, string className);
        /// <summary>
        /// 根据表名生成类字符串
        /// </summary>
        /// <param name="db"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        string TableNameToClass(ISqlSugarClient db, string tableName);
    }
}
