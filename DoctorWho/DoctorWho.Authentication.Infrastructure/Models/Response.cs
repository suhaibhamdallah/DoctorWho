namespace DoctorWho.Authentication.Infrastructure.Models
{
    public class Response
    {
        public Response()
        {

        }

        public Response(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
