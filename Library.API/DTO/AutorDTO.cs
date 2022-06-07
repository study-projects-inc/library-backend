using Library.Core.Classes;

namespace Library.API.DTO
{
    public class AutorDTO
    {
        public long? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

    }

    public static class AutorDTOFactory
    {
        public static AutorDTO ToDTO(this AutorCanonico autor)
        {
            return new AutorDTO()
            {
                Id = autor.Id,
                Nome = autor.Nome,
                Descricao = autor.Descricao
            };
        }
    }
}
