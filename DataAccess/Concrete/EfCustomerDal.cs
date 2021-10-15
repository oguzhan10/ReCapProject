using Core1.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCustomerDal : EfEntitiyRepositoryBase<Customer, CarsDB>, ICustomerDal
    {

    }
}
