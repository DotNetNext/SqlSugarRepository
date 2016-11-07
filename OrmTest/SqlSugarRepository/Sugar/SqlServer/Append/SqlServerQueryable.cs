using SqlSugarRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugarRepository
{
    class SqlServerQueryable<T> : ISugarQueryable<T>
    {
        public object QueryableCore
        {
            get;set;
        }

        public ISugarQueryable<T> JoinTable<T2>(System.Linq.Expressions.Expression<Func<T, T2, object>> expression, JoinType type = JoinType.LEFT)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> JoinTable<T2, T3>(System.Linq.Expressions.Expression<Func<T, T2, T3, object>> expression, JoinType type = JoinType.LEFT)
        {
            throw new NotImplementedException();
        }

        public TResult Max<TResult>(string maxField)
        {
            throw new NotImplementedException();
        }

        public TResult Min<TResult>(string minField)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> OrderBy<T2>(System.Linq.Expressions.Expression<Func<T, T2, object>> expression, OrderByType type = OrderByType.asc)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T2> Select<T2>(string select)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<T, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<TResult> Select<T2, TResult>(System.Linq.Expressions.Expression<Func<T, T2, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<TResult> Select<T2, T3, TResult>(System.Linq.Expressions.Expression<Func<T, T2, T3, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<TResult> Select<T2, T3, T4, TResult>(System.Linq.Expressions.Expression<Func<T, T2, T3, T4, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<TResult> Select<T2, T3, T4, T5, TResult>(System.Linq.Expressions.Expression<Func<T, T2, T3, T4, T5, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> Where<T2>(System.Linq.Expressions.Expression<Func<T, T2, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> Where<T2>(string whereString, object whereObj = null)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> Where<T2, T3>(System.Linq.Expressions.Expression<Func<T, T2, T3, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> Where<T2, T3, T4>(System.Linq.Expressions.Expression<Func<T, T2, T3, T4, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ISugarQueryable<T> Where<T2, T3, T4, T5>(System.Linq.Expressions.Expression<Func<T, T2, T3, T4, T5, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
