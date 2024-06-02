﻿namespace Chirper_CS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public IEnumerable<Chirp>? Chirps { get; set; }
    }
}
