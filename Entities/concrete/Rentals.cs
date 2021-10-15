using Core1.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.concrete
{
    public class Rentals : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }
    }
}
