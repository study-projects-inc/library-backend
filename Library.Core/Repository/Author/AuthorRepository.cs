using Library.Core.Classes;
using Library.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.Core.Repository.Author
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _context;
        public AuthorRepository(LibraryContext context)
        {
            this._context = context;
        }
        public async Task<List<AutorCanonico>> Get()
        {
            return await _context.Authors.Select(a => a.ToCanonico()).ToListAsync();
        }

        public async Task<AutorCanonico> GetById(long id)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(author => author.AuthorId == id);
            return author!.ToCanonico();
        }
    }
}
