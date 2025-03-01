﻿using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        List<Color> GetAll();
        List<Color> GetByColorId(int id);
        List<Color> GetByName(string name);
    }
}
