using CompanyEmployee.Contracts;
using CompanyEmployee.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CompanyEmployee.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationContext _context;

        public RepositoryBase(ApplicationContext context)
        {
            _context = context;
        }

        public System.Linq.IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? _context.Set<T>()
                            .AsNoTracking() : _context.Set<T>();


        public System.Linq.IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? _context.Set<T>()
                            .Where(expression)
                            .AsNoTracking() : _context.Set<T>()
                            .Where(expression);

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
