using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Domain.Entities
{
    public class Project
    {
        public Guid ProjectID { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string CompanyCustomer { get; set; }
        public string PerfomingCompany { get; set; }
        public int? LeadEmployeeId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public int ProjectPriority { get; set; }

        public virtual ICollection<ProjectEmployees> ProjectEmployees { get; set; }
    }
}
