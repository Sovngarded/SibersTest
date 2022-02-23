using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.ApplicationService.DTO
{
    public class ProjectEmployeesDTO
    {
        public Guid ProjectEmployeeID { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

    }
}
