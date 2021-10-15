using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //customerManager.AddCustomer(new Customer{ UserId = 1, CompanyName = "Oguzhan" });


            RentalsManager rentalsManager = new RentalsManager(new EfRentalsDal());

            rentalsManager.Add(new Rentals { CarId = 1, CustomerId = 1, Id = 1, RentDate = new DateTime(2021, 9, 26),ReturnDate= new DateTime(2021,9,26) });

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var item in brandManager.GetByColor("blue"))            
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
