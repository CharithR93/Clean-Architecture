using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Domain.Entities;

namespace Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }

       DbSet<Department> Departments { get; set; }

       Task<int> SaveChanges(CancellationToken cancellationToken);
    }
}
