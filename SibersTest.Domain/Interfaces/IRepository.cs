using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task Create(T entityitem);
        Task Edit(T entityoriginal, T entityfinal);
        Task Delete(T entityitem);
        Task<T> IsExist(T entityitem);
    }
}
