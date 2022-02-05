using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;

namespace Tiqri.CleanArchitectureTemplate.Persistance.EfCore
{
    public class EfCoreUnitOfWork : IUnitOfWork
    {
        public readonly ApplicationDbContext _dbContext;

        public EfCoreUnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task BeginAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();

        }

        public Task RollbackAsync()
        {
            throw new NotImplementedException();
        }
    }
}
