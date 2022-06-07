using Library.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository.Author
{
    public interface IAuthorRepository
    {
        Task<List<AutorCanonico>> Get();
        Task<AutorCanonico> GetById(long id);
    }
}
