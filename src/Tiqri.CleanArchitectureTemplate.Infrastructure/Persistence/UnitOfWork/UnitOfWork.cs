using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;
using Tiqri.CleanArchitectureTemplate.Infrastructure.Persistence.Context;
using Tiqri.CleanArchitectureTemplate.Infrastructure.Persistence.Repositories;

namespace Tiqri.CleanArchitectureTemplate.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
        }
        public IEmployeeRepository Employees { get;  set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
