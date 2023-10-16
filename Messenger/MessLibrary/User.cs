using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MessLibrary
{
    public class User
    {

        [Key]
        [Required]
        [MaxLength(20)]
        public string Username { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; private set; }

        [MaxLength(50)]
        public string FirstName { get; private set; }

        [MaxLength(50)]
        public string LastName { get; private set; }

        [MaxLength(100)]
        public string Email { get; private set; }

        [ForeignKey("User")]
        [MaxLength(100)]
        public string[]? Contacts { get; set; }

        public bool Online { get; set; }

        [MaxLength(12)]
        public string LastOnline { get; set; }

        public User() { }
        public User(string username, string password, string firstName, string lastName, string email)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            LastOnline = DateTime.Now.ToString("dd-MM, hh:mm");
            Online = true;
        }
    }
}