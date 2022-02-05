using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;

namespace Tiqri.CleanArchitectureTemplate.Persistance.EfCore
{
    public class EfCoreBaseRepository<T> : IRepository<T>, IAddRange<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _entity;

        public EfCoreBaseRepository()
        {

        }

        public EfCoreBaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }


        public virtual Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task EditAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetByIdAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<T>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
