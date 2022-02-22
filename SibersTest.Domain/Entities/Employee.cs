using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Domain.Entities
{
    public partial class Employee
    {
       
       
        public Guid EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeSurname { get; set; }
        
        public string Email { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<ProjectEmployees> ProjectsEmployees { get; set; }
    }
}
