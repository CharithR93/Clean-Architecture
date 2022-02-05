using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.CleanArchitectureTemplate.Domain;

namespace Tiqri.CleanArchitectureTemplate.Domain
{
    public class Department: AuditableEntity
    {
        public int Id { get; private set; }
        public string Code { get; private  set; }
        public string Name { get; private set; }
    }
}
