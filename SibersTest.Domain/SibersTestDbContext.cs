
using SibersTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using System.Threading.Tasks;


namespace SibersTest.Domain
{
    public class SibersTestDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectEmployees> ProjectsEmployees { get; set; }
        public virtual DbSet<Objective> Objective { get; set; }

       
        public SibersTestDbContext() : base("name=SibersTestDB")
        {
        }
    }
}

