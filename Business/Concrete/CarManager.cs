using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core1.Aspects.Autofac.Validation;
using Core1.Constants;
using Core1.CrossCuttingConcerns.Validation;
using Core1.Utilities;
using DataAccess.Abstract;
using Entities.concrete;
using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {            

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23 )
            {
                return new ErrorDataResult<List<Car>>("getirilmedi");
            }

            return  new SuccessDataResult<List<Car>>(_carDal.GetAll(),"getirildi");
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetByName(string name)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Name == name));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

    }
}
