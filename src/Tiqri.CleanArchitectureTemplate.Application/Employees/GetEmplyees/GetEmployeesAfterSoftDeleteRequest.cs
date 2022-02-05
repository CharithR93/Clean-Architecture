using MediatR;
using System.Collections.Generic;

namespace Tiqri.CleanArchitectureTemplate.Application.Employees.GetEmplyees
{
    public record GetEmployeesAfterSoftDeleteRequest(List<int> Ids) : IRequest<List<EmployeeDto>>;
}
