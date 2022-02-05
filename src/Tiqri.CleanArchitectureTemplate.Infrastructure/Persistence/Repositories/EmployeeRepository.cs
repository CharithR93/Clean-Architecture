using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;
using Tiqri.CleanArchitectureTemplate.Domain.Entities;
using Tiqri.CleanArchitectureTemplate.Infrastructure.Persistence.Context;

namespace Tiqri.CleanArchitectureTemplate.Infrastructure.Persistence.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
        public void GetAllBestEmployees(string code)
        {
            throw new NotImplementedException();
        }
    }
}
