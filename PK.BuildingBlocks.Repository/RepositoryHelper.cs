using System;
using System.Linq;
using System.Linq.Expressions;

namespace PK.BuildingBlocks.Repository
{
    public static class RepositoryHelper
    {
        public enum OrderBy
        {
            ASC,
            DESC
        }

        public static IQueryable<T> SortBy<T>(this IQueryable<T> source, string sortBy, OrderBy sortDirection) where T : class
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "item");
            Expression<Func<T, object>> keySelector = Expression.Lambda<Func<T, object>>(Expression.Convert(Expression.Property(parameterExpression, sortBy), typeof(object)), new ParameterExpression[1]
            {
            parameterExpression
            });
            return sortDirection switch
            {
                OrderBy.ASC => source.OrderBy(keySelector),
                OrderBy.DESC => source.OrderByDescending(keySelector),
                _ => source,
            };
        }
    }
}

