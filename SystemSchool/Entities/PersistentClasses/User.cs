using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IEntity
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
