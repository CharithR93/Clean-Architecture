using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
         IEmployeeRepository Employees { get;  set; }
        int Complete();
    }
}
