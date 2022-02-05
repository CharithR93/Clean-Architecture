using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.CleanArchitectureTemplate.Domain
{
    public class AuditableEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedId { get; set; } = 1;
        public int ModifiedId { get; set; } = 1;
    }
}
