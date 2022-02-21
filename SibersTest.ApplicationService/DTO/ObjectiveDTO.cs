using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.ApplicationService.DTO
{
    public class ObjectiveDTO
    {
        public Guid ObjectiveID { get; set; }
        public int ProjectID { get; set; }
        public int ObjectiveAuthorID { get; set; }
        public int ObjectiveExecutorID { get; set; }
        public TaskStatus? ObjectiveStatus { get; set; }
        public string ObjectiveComment { get; set; }
        public int ObjectivePriority { get; set; }
        
    }
}
