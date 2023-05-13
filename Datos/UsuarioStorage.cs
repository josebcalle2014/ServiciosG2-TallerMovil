using ServiciosClinicaUNMSM.Modelos.Dto;

namespace ServiciosClinicaUNMSM.Datos
{
    public static class UsuarioStorage
    {
        public static List<UsuarioDto> usuarioList = new List<UsuarioDto>()
        {
            new UsuarioDto{id_usuario=1, correo="josebcalle2014@gmail.com"},
            new UsuarioDto{id_usuario=2, correo="aparodi@upch.com"}
        };
    }
}
