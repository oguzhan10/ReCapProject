using Business.Abstract;
using Core1.Utilities;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customer;
        public CustomerManager(ICustomerDal customer)
        {
            _customer = customer;
        }

        public void AddCustomer(Customer customer)
        {
            _customer.Add(customer);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customer.GetAll());
        }

        public IDataResult<List<Customer>> GetByCompanyName(string CompanyName)
        {
            var result = _customer.GetAll(c => c.CompanyName == CompanyName);
            return new SuccessDataResult<List<Customer>>(result);
        }

        public IDataResult<List<Customer>> GetByUserId(int userId)
        {
            var result = _customer.GetAll(c => c.UserId == userId);
            return new SuccessDataResult<List<Customer>>(result);
        }
    }
}
