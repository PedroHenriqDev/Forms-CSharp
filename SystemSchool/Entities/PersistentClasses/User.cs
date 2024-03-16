using Entities.Interfaces;
using System;

namespace Entities
{
    public class User : IEntity<User>
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int GroupId { get; set; }
        public DateTime DateCreation { get; set; }
        public Group Group { get; set; }

        public User()
        {
        }

        public User(int id, string username, string passwordHash, int groupId, DateTime dateCreation) 
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            GroupId = groupId;
            DateCreation = dateCreation;
        }
    }
}
