using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Domain.Entities
{
    public class ProjectEmployees
    {
       
        public Guid ProjectEmployeeID { get; set; }
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
