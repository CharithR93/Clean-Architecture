using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Domain.Entities;

namespace Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        void GetAllBestEmployees(string code);
    }
}
