using Clase2._2C2025.Entidad;
using Clase2._2C2025.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2._2C2025.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuplexController : ControllerBase
    {
        IDuplexServicio _duplexServicio;

        public DuplexController(IDuplexServicio duplexServicio)
        {
            _duplexServicio = duplexServicio;
        }

        [HttpGet]
        public IActionResult GetDuplex()
        {
            return Ok(_duplexServicio.ObtenerDuplexes());
        }

        [HttpPost]
        public IActionResult PostDuplex( [FromBody] Duplex duplex)
        {
            _duplexServicio.AgregarDuplex(duplex);
            return Ok();
        }
    }
}
