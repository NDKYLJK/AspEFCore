using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspEFCore.Web.Service
{
    public interface IRepository<T> where T : class
    {

        List<T> GetAll();
        T GetById(int id);
        T Add(T newModel);
        T Update(int id, T newModel);
        T Delete(int id);

    }
}
