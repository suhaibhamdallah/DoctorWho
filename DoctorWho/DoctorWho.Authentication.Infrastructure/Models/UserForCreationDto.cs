﻿namespace DoctorWho.Authentication.Infrastructure.Models
{
    public class UserForCreationDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int NetworkType { get; set; }
    }
}
