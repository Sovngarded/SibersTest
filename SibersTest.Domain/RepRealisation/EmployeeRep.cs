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
    public class EmployeeRep<T> : IRepository<Employee>
    {
        private SibersTestDbContext db;

        public EmployeeRep(SibersTestDbContext sibersTestDBContext)
        {
            db = sibersTestDBContext;
        }

        public async Task<Employee> IsExist(Employee emp)
        {
            if (emp == null) return null;
            Employee e = await db.Employees.AsNoTracking().FirstOrDefaultAsync(x => x.EmployeeName == emp.EmployeeName && x.EmployeeSurname == emp.EmployeeSurname && x.EmployeeMiddleName == emp.EmployeeMiddleName || x.Email == emp.Email);
            if (e != null)
                return e;
            return null;
        }

        public async Task Create(Employee emp)
        {
            Employee e = await IsExist(emp);
            if (e == null)
                db.Employees.Add(emp);

        }

        public async Task Delete(Employee emp)
        {
            Employee e = await IsExist(emp);
            if (e != null && e.EmployeeID == emp.EmployeeID)
                db.Employees.Remove(e);
        }

       
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task Edit(Employee entityoriginal, Employee entityfinal)
        {
            Employee s = await IsExist(entityoriginal);
            Employee d = await IsExist(entityfinal);
            if (s != null && d == null)
            {
                entityfinal.EmployeeID = s.EmployeeID;
                db.Entry(entityfinal).State = EntityState.Modified;
            }
        }


    }
}
