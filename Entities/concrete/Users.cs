using Core1.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class Users : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}