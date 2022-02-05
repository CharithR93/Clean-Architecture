using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;
using Tiqri.CleanArchitectureTemplate.Domain.Entities;

namespace Tiqri.CleanArchitectureTemplate.Infrastructure.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set ; }

        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }


    }
}
