using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;
using Tiqri.CleanArchitectureTemplate.Application.Interfaces;
using Tiqri.CleanArchitectureTemplate.Domain;

namespace Tiqri.CleanArchitectureTemplate.Application.Employees.GetEmplyees
{

    public class SoftDeleteEmployeeHandler : IRequestHandler<GetEmployeesAfterSoftDeleteRequest, List<EmployeeDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepository _employeeRepository;

        public SoftDeleteEmployeeHandler(IUnitOfWork unitOfWork, IEmployeeRepository employeeRepository)
        {
            _unitOfWork = unitOfWork;
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeDto>> Handle(GetEmployeesAfterSoftDeleteRequest request, CancellationToken cancellationToken)
        {
            request.Ids.ForEach(async id =>
            {
                var employee = await _employeeRepository.GetByIdAsync(id);                
                ((ISoftDelete)employee).SoftDelete();
                await _employeeRepository.SoftDeleteAsync(employee);
            });

            await _unitOfWork.CommitAsync();

            return new List<EmployeeDto>();


            // TODO: active this line
            //return await _employeeRepository.ListAsync();

        }
    }
}
