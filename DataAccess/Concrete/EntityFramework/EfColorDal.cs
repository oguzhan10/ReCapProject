﻿using Core1.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntitiyRepositoryBase<Color, CarsDB> , IColorDal
    {
    }
}
