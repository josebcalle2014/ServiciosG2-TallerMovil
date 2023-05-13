using System.Runtime.CompilerServices;

namespace ServiciosClinicaUNMSM.Dominio
{
    public class IRequestAutenticacion
    {
        public string sCorreo { get; set; }
        public string sClave { get; set; }
        public string sVerApp { get; set; }
        public string sVerAnd { get; set; }
        public string sModCel { get; set; }

    }

    public class IResponseAutenticacion
    {
        public int nRetorno { get; set; }
        public string sRetorno { get; set; }
        public IUsuarioAutenticacion oUsuario { get; set; }
    }

    public class IUsuarioAutenticacion
    {
        public int nIdUsu { get; set; }
        public string sUser { get; set; }
        public string sPassword { get; set; }
        public string sNombre { get; set; }
        public string sApellidoPaterno { get; set; }
        public string sApellidoMaterno { get; set; }
        public string sCorreo { get; set; }
        public string sCelular { get; set; }
        public string sDocumento { get; set; }
        public string imagen { get; set; }
        public int estado { get; set; }
    }
}
