using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Interfaces;
using Tiqri.CleanArchitectureTemplate.Domain;

namespace Tiqri.CleanArchitectureTemplate.Persistance.EfCore.Reporsitories
{
    public class EmployeeRepository : EfCoreBaseRepository<Employee>, IEmployeeRepository
    {
        public async Task SoftDeleteAsync(Employee employee)
        {   
            await base.EditAsync(employee);
        }
    }
}
