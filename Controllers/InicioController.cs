using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiciosClinicaUNMSM.Datos;
using ServiciosClinicaUNMSM.Modelos.Dto;

namespace ServiciosClinicaUNMSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InicioController : ControllerBase
    {
        private readonly ILogger<InicioController> _logger;
        private readonly ApplicationDBContext _db;

        public InicioController(ILogger<InicioController> logger, ApplicationDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet("ListaNoticias")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<NoticiasDto>> GetNoticias() 
        {
            _logger.LogInformation("Lista de noticias");
            return Ok(_db.Noticias.ToList());
        }
    }
}
