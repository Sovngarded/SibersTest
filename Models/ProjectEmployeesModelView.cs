using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SibersTest.Web.Models
{
    public class ProjectEmployeesModelView
    {
        public Guid ProjectEmployeeID { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
    }
}
