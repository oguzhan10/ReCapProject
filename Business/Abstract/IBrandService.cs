using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        List<Brand> GetAll();
        List<Brand> GetByCarId(int id);
        List<Brand> GetByColor(string color);
    }
}
