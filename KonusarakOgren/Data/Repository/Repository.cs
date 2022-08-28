using Core.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Context _context;
        private readonly DbSet<T> _dbset;
        public Repository(Context context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public void AddRange(List<T> entities)
        {
            _dbset.AddRange(entities);
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _dbset.Any(expression);
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbset.AsNoTracking().AsQueryable();
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return expression == null ? _dbset.AsNoTracking() : _dbset.Where(expression).AsNoTracking();
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);
        }

        public void Update(T entity)
        {
            _dbset.Update(entity);
        }

        public void UpdateRange(List<T> entities)
        {
            _dbset.UpdateRange(entities);
        }
    }
}
