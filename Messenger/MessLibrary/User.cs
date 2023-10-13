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
        public string Password { get; private set; }

        [ForeignKey("User")]
        [MaxLength(100)]
        public string[]? Contacts { get; set; }

        public bool Online { get; set; }

        public string LastOnline { get; set; }

        public User() { }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            LastOnline = DateTime.Now.ToString();
            Online = true;
        }
    }
}