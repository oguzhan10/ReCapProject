﻿using Core1.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
