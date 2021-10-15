using Core1.Utilities;
using Entities.concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByBrandId(int id);
        IDataResult<List<Car>> GetByName(string name);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
