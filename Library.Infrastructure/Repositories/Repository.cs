using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repositories
{
    internal interface Repository<T, ID>
    {
        Task<List<T>> Get();

        Task<T> GetById(ID id);

    }
}
