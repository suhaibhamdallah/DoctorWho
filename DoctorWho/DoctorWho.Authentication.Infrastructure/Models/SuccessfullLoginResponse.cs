using System;

namespace DoctorWho.Authentication.Infrastructure.Models
{
    public class SuccessfullLoginResponse : Response
    {
        public SuccessfullLoginResponse(int statusCode,
            string message,
            string token,
            DateTime expiration) : base(statusCode, message)
        {
            Token = token;
            Expiration = expiration;
        }

        public string Token { get; private set; }
        public DateTime Expiration { get; private set; }
    }
}
