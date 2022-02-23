using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SibersTest.Web.Models
{
    public class ProjectModelView
    {
        public Guid ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string CompanyCustomer { get; set; }
        public string PerfomingCompany { get; set; }
        public int? LeadEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProjectPriority { get; set; }
    }
}
