﻿namespace Napredne_baze_podataka_API.DTOs
{
    public class RegistrationRequestDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? BirthDate { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
