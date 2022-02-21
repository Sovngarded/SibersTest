using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Domain.Entities
{
    public class Objective
    {
       [Key] public Guid ObjectiveID { get; set; }
        public int ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public virtual Objective Project { get; set; }
        public int ObjectiveAuthorID { get; set; }
        [ForeignKey("ObjectiveAuthorID")]
        public virtual Employee EmployeeAuthor { get; set; }
        public int ObjectiveExecutorID { get; set; }
        [ForeignKey("ObjectiveExecutorID")]
        public virtual Employee EmployeeExecutor { get; set; }  
        public Status? ObjectiveStatus { get; set; }
        public string ObjectiveComment { get; set; }
        public int ObjectivePriority { get; set; }

        public enum Status
        {
            ToDo, InProgress, Done
        }
    }
}
