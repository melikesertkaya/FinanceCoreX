﻿using System.Linq.Expressions;

namespace FinanceCoreX.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task<IList<T>> Search(int pageIndex, int pageSize, Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        void Update(T entity);

        Task DeleteAsync(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }
}
