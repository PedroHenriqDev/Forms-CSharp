using Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Entities
{
    public class Group : IEntity<Group>
    {
        public int Id { get; set; }
        public int AccessLevel {get; set;}
        public string GroupName { get; set; }
        public DateTime DateCreation {  get; set; }
        public List<User> Users { get; set; }
    }
}
