using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SqlSugarRepository
{
    /// <summary>
    /// 拉姆达表达示操作
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISugarQueryable<T>
    {
        /// <summary>
        /// 存储queryable的对象
        /// </summary>
        object QueryableCore { get; set; }
        ISugarQueryable<T> JoinTable<T2>(Expression<Func<T, T2, object>> expression, JoinType type = JoinType.LEFT);
        ISugarQueryable<T> JoinTable<T2, T3>(Expression<Func<T, T2, T3, object>> expression, JoinType type = JoinType.LEFT);
        TResult Max<TResult>(string maxField);
        TResult Min<TResult>(string minField);
        ISugarQueryable<T> OrderBy<T2>(Expression<Func<T, T2, object>> expression, OrderByType type = OrderByType.asc);
        ISugarQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> expression);
        ISugarQueryable<T2> Select<T2>(string select);
        ISugarQueryable<TResult> Select<T2, TResult>(Expression<Func<T, T2, TResult>> expression);
        ISugarQueryable<TResult> Select<T2, T3, TResult>(Expression<Func<T, T2, T3, TResult>> expression);
        ISugarQueryable<TResult> Select<T2, T3, T4, TResult>(Expression<Func<T, T2, T3, T4, TResult>> expression);
        ISugarQueryable<TResult> Select<T2, T3, T4, T5, TResult>(Expression<Func<T, T2, T3, T4, T5, TResult>> expression);
        ISugarQueryable<T> Where<T2>(Expression<Func<T, T2, bool>> expression);
        ISugarQueryable<T> Where<T2>(string whereString, object whereObj = null);
        ISugarQueryable<T> Where<T2, T3>(Expression<Func<T, T2, T3, bool>> expression);
        ISugarQueryable<T> Where<T2, T3, T4>(Expression<Func<T, T2, T3, T4, bool>> expression);
        ISugarQueryable<T> Where<T2, T3, T4, T5>(Expression<Func<T, T2, T3, T4, T5, bool>> expression);
    }
}
