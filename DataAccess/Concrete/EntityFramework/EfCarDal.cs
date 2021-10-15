using Core1.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, CarsDB>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsDB carsDB = new CarsDB())
            {
                var result = from cars in carsDB.Cars
                             join colors in carsDB.Colors
                             on cars.ColorId equals colors.Id
                             join brands in carsDB.Brands
                             on cars.BrandId equals brands.Id
                             select new CarDetailDto
                             {
                                 BrandName = cars.Brand,
                                 CarName = cars.Name,
                                 ColorName = cars.Color,
                                 DailyPrice = cars.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
