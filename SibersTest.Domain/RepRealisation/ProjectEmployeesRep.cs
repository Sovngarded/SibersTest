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

    public class ProjectsEmployeesRep<T> : IRepository<ProjectEmployees>
    {
        private SibersTestDbContext db;

        public ProjectsEmployeesRep(SibersTestDbContext sibersTestDB)
        {
            db = sibersTestDB;
        }

        public async Task<ProjectEmployees> IsExist(ProjectEmployees projectsEmployees)
        {
            if (projectsEmployees == null)
                return null;
            ProjectEmployees pe = await db.ProjectsEmployees
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(p =>
                                            p.EmployeeID == projectsEmployees.EmployeeID &&
                                            p.ProjectID == projectsEmployees.ProjectID);
            if (pe == null) return null;
            return pe;
        }

        public async Task Create(ProjectEmployees projectsEmployees)
        {
            ProjectEmployees pe = await IsExist(projectsEmployees);
            if (pe == null)
                db.ProjectsEmployees.Add(projectsEmployees);
        }

        public async Task Delete(ProjectEmployees projectsEmployees)
        {
            ProjectEmployees pe = await IsExist(projectsEmployees);
            if (projectsEmployees != null && projectsEmployees.ProjectEmployeeID == pe.ProjectEmployeeID)
                db.ProjectsEmployees.Remove(projectsEmployees);
        }

 
      

        public async Task<IEnumerable<ProjectEmployees>> GetAll()
        {
            return await db.ProjectsEmployees.ToListAsync();
        }

        public async Task Edit(ProjectEmployees entityoriginal, ProjectEmployees entityfinal)
        {
            ProjectEmployees s = await IsExist(entityoriginal);
            ProjectEmployees d = await IsExist(entityfinal);
            if (s != null && d == null)
            {
                entityfinal.ProjectEmployeeID = s.ProjectEmployeeID;
                db.Entry(entityfinal).State = EntityState.Modified;
            }
        }
    }
}
