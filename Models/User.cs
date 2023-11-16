using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Role { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Desc { get; set; }
    }
}