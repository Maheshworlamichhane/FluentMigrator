using HRMS.Entity.DBContext;
using HRMS.Repository.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Repository.Repository.Impl
{
    public class GenericRepositoryImpl<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDBContext _DbContext;
        private DbSet<T> _DbSet;

        public GenericRepositoryImpl(ApplicationDBContext dbContext)
        {
            this._DbContext = dbContext;
            this._DbSet = this._DbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            this._DbSet.Remove(entity);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._DbSet.ToListAsync();
        }

        public async Task<T> GetByKey(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await this._DbSet.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task Insert(T entity)
        {
            await this._DbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            this._DbSet.Attach(entity);
            this._DbContext.Entry(entity).State = EntityState.Modified;

        }
        public int Save()
        {
            return _DbContext.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _DbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public IEnumerable<T> GetAllList()
        {
            return this._DbSet.ToList();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_DbSet == null)
                    _DbSet = _DbContext.Set<T>();
                return _DbSet;
            }
        }

        public IQueryable<T> TableNoTracking
        {

            get
            {
                return this.Entities.AsNoTracking();
            }
        }
    }
}
