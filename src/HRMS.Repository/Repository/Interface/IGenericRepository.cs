using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Repository.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> GetAllList();
        Task Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetByKey(int id);
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        int Save();
    }
}
