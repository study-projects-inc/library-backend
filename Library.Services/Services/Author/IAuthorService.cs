using Library.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Services.Author
{
    public interface IAuthorService
    {
        public Task<List<AutorCanonico>> Get();
    }
}
