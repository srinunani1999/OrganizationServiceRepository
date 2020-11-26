using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationService.Repositories
{
    public interface IRepositories<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);
        void Add(T org);
        T Update(T organization);
    }
}
