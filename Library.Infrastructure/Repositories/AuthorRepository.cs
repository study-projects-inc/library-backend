using Library.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace Library.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author, long>
    {
        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            this._context = context;
        }

        public async Task<List<Author>> Get()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<Author> GetById(long id)
        {
            return await _context.Authors.FirstOrDefaultAsync(author => author.AuthorId == id);
        }
    }
}
