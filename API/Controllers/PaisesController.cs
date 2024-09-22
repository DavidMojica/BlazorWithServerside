using Microsoft.AspNetCore.Mvc;
using Modelos;
using Modelos.Entidades;
using Modelos.Negocio;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly PaisNegocio _paisNegocio;
        public PaisesController(IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            _paisNegocio = new PaisNegocio(connectionString);
        }

        [HttpGet]
        public ActionResult<List<Pais>> GetPaises()
        {
            var paises = _paisNegocio.ObtenerPaises();
            return Ok(paises);
        }
    }
}
