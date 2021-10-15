using Core1.Utilities;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService 
    {
        void AddCustomer(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetByCompanyName(string CompanyName);
        IDataResult<List<Customer>> GetByUserId(int userId);
    }
}
