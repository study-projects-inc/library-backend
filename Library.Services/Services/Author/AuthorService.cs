using Library.Core.Classes;
using Library.Core.Repository.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Services.Author
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository _repository;

        public AuthorService(IAuthorRepository repository)
        {
            this._repository = repository;
        }
        public Task<List<AutorCanonico>> Get()
        {
            return _repository.Get();
        }
    }
}
