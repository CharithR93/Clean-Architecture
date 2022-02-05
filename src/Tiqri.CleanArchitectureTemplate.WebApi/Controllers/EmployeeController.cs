using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Application.Common.Interfaces;

namespace Tiqri.CleanArchitectureTemplate.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EmployeeController> _logger;


        public EmployeeController(ILogger<EmployeeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public void Get()
        {
            var employees =  _unitOfWork._employees.GetAll();
        }
    }
}
