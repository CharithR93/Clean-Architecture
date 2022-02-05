using System;

namespace Tiqri.CleanArchitectureTemplate.Application.Employees
{
    public record EmployeeDto(string code, string FirstName, string LastName, string ContactNo, bool IsSoftDeleted, DateTime CreatedDate, DateTime ModifiedDate);
}
