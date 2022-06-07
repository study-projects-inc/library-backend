using Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Classes
{
    public class AutorCanonico
    {
        public long Id { get; }
        public string? Nome { get; }
        public string? Descricao { get; set; }

        public AutorCanonico(string? nome)
        {
            this.Nome = nome;
        }

        public AutorCanonico(long id, string? nome)
        {
            this.Nome = nome;
            this.Id = id;
        }

    }

    public static class AuthorCanonicoFactory
    {
        public static AutorCanonico ToCanonico(this Author author)
        {
            return new AutorCanonico(author.AuthorId, author.Name)
            {
                Descricao = author.Description
            };
        }
    }
}
