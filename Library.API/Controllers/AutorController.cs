using Library.API.DTO;
using Library.Core.Classes;
using Library.Services.Services.Author;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private IAuthorService _service;

        public AutorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<AutorDTO>> GetAuthors()
        {
            var autores = await _service.Get();
            return autores.Select(e => e.ToDTO()).ToList();
        }
    }
}
