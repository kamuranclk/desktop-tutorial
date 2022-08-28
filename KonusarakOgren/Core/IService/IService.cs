using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.IService
{
    public interface IService<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        List<T> GetBy(Expression<Func<T, bool>> expression);
        void Addservis(T entity);
        void Update(T entity);
        void Delete(T entity);
        void AddRange(List<T> entities);
        void UpdateRange(List<T> entities);
        bool Any(Expression<Func<T, bool>> expression);
    }
}
