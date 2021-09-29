using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
   public interface IgenRepo<T> where T:class,IBM
    {
        Task Add(T t);
        Task DeleteByID(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
        

    }
}
