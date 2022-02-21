using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.ApplicationService.DTO
{
    public class EmployeeDTO
    {
        public Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Email { get; set; }
    }
}