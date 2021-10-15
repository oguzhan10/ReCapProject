using Core1.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
    }
}