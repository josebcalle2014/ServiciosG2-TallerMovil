namespace ServiciosClinicaUNMSM.Modelos
{
    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; } = "";
    }

    public class WebApiResponse<T>
    {
        public bool Success { get; set; }
        public Object? Response { get; set; }
        public List<Error> Errors { get; set; }
    }
}
