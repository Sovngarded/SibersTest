using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibersTest.ApplicationService.Interface
{
    public interface IDataUsage<T> where T : class
    {
        Task<IEnumerable<T>> Create(T entityitem);
        Task Edit(T entityoriginal, T entityfinal);
        Task Delete(T entityitem);
        Task<IEnumerable<T>> GetAll();



    }
}
