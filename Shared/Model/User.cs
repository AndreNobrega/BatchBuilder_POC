﻿namespace Shared.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}