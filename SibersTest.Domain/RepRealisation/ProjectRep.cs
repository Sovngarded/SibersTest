using SibersTest.Domain.Entities;
using SibersTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Domain.Realisation
{
    public class ProjectRep<T> : IRepository<Project>
    {
        private SibersTestDbContext db;

        public ProjectRep(SibersTestDbContext sibersTestDB)
        {
            db = sibersTestDB;
        }
        public async Task<Project> IsExist(Project project)
        {
            if (project == null) return null;
            Project e = await db.Projects.AsNoTracking().Include(p => p.LeadEmployeeId)
                .FirstOrDefaultAsync
                (x =>
                    x.ProjectName == project.ProjectName &&
                    x.CompanyCustomer == project.CompanyCustomer &&
                    x.StartDate == project.StartDate &&
                    x.EndDate == project.EndDate &&
                    x.LeadEmployeeId == project.LeadEmployeeId &&
                    x.PerfomingCompany == project.PerfomingCompany &&
                    x.ProjectPriority == project.ProjectPriority
                );
            if (e != null)
                return e;
            return null;
        }

        public async Task Create(Project project)
        {
            Project p = await IsExist(project);
            if (p == null)
                db.Projects.Add(project);


        }

        public async Task Delete(Project project)
        {
            Project p = await IsExist(project);
            if (p != null && project.ProjectID == p.ProjectID)
                db.Projects.Remove(project);
        }

        public IEnumerable<Project> Find(Func<Project, bool> predicate)
        {
            return db.Projects.Include(e => e.ProjectEmployees).Where(predicate).ToList();
        }

        public async Task<Project> Get(int? id)
        {
            if (id == null) return null;
            return await db.Projects.FindAsync(id);
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await db.Projects.ToListAsync();
        }

        public async Task Edit(Project source, Project dest)
        {
            Project s = await IsExist(source);
            Project d = await IsExist(dest);
            if (s != null && d == null)
            {
                dest.ProjectID = s.ProjectID;
                db.Entry(dest).State = EntityState.Modified;
            }
        }
    }
}
