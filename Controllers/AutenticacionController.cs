using Microsoft.AspNetCore.Mvc;
using ServiciosClinicaUNMSM.Datos;
using ServiciosClinicaUNMSM.Dominio;
using ServiciosClinicaUNMSM.Modelos;
using ServiciosClinicaUNMSM.Modelos.Dto;

namespace ServiciosClinicaUNMSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AutenticacionController> _logger;
        private readonly ApplicationDBContext _db;
        //private readonly JwtAuthenticationManager _jwtAuthenticationManager;

        public AutenticacionController(ILogger<AutenticacionController> logger, ApplicationDBContext db)
        {
            _logger = logger;
            _db = db;
        }


        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UsuarioDto> LoginUsuario([FromBody] UsuarioDto usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (_db.Usuarios.FirstOrDefault(v => v.correo.ToLower() == usuarioDto.correo.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "El usuario con ese nombre ya existe");
                return BadRequest(ModelState);
            }
            if (usuarioDto == null)
            {
                return BadRequest(ModelState);
            }
            if (usuarioDto.id_usuario > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Usuario modelo = new()
            {
                nombre = usuarioDto.nombre,
                apellidoPaterno = usuarioDto.apellidoPaterno,
                apellidoMaterno = usuarioDto.apellidoMaterno,
                correo = usuarioDto.correo,
                contrasenia = usuarioDto.contrasenia,
                fechaCreacion = usuarioDto.fechaCreacion,
                fechaActualizacion = usuarioDto.fechaActualizacion,
                imagen = usuarioDto.imagen,
                estado = usuarioDto.estado
            };
            _db.Usuarios.Add(modelo);
            _db.SaveChanges();
            return NoContent();
        }

        /*[HttpPost("Login")]
        public async Task<ActionResult<WebApiResponse<IResponseAutenticacion>>> Login(IRequestAutenticacion auth)
        {
            WebApiResponse<IResponseAutenticacion> response = new WebApiResponse<IResponseAutenticacion>();

            try
            {
                IResponseAutenticacion result = new IResponseAutenticacion();
                var res = await _unit
            }
        
        }*/


        //VALIDAR CORREO ELECTRÓNICO PARA EL CAMBIO DE PASSWORD
        [HttpGet("ValidarCorreo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UsuarioDto> GetUsuario(string correo_usuario)
        {
            if (correo_usuario.Equals(""))
            {
                _logger.LogError("Error de response");
                return BadRequest();
            }
            var usuario = _db.Usuarios.FirstOrDefault(v => v.correo == correo_usuario);
            if(usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        //REGISTRO DE UN USUARIO
        [HttpPost("CrearUsuario")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UsuarioDto> CrearUsuario([FromBody] UsuarioDto usuarioDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(_db.Usuarios.FirstOrDefault(v=>v.correo.ToLower() == usuarioDto.correo.ToLower())!=null)
            {
                ModelState.AddModelError("CorreoExiste", "El usuario con ese correo ya existe");
                return BadRequest(ModelState);
            }
            if(usuarioDto == null)
            {
                return BadRequest(ModelState);
            }
            if (usuarioDto.id_usuario > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Usuario modelo = new()
            {
                nombre = usuarioDto.nombre,
                apellidoPaterno = usuarioDto.apellidoPaterno,
                apellidoMaterno = usuarioDto.apellidoMaterno,
                correo = usuarioDto.correo,
                contrasenia = usuarioDto.contrasenia,
                fechaCreacion = usuarioDto.fechaCreacion,
                fechaActualizacion = usuarioDto.fechaActualizacion,
                imagen = usuarioDto.imagen,
                estado = usuarioDto.estado
            };
            _db.Usuarios.Add(modelo);
            _db.SaveChanges();
            return NoContent();
        }


    }
}
