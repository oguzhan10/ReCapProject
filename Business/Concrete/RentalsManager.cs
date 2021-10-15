using Business.Abstract;
using Core1.Utilities;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rental;
        public RentalsManager(IRentalsDal rental)
        {
            _rental = rental;
        }

        public void Add(Rentals rent)
        {
            _rental.Add(rent);
        }
    }
}
