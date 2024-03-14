using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : IEntity<User>
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int ClassId { get; set; }
        public DateTime DateCreation { get; set; }
        public Class Class { get; set; }

        public User()
        {
        }

        public User(int id, string username, string passwordHash, int classId, DateTime dateCreation) 
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            ClassId = classId;
            DateCreation = dateCreation;
        }
    }
}
