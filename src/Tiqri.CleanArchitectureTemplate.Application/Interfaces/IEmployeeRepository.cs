using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;
using Tiqri.CleanArchitectureTemplate.Domain;

namespace Tiqri.CleanArchitectureTemplate.Application.Interfaces
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        Task SoftDeleteAsync(Employee employee);
    }
}
