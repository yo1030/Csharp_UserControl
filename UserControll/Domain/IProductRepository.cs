﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControll.Domain
{
    public interface IProductRepository
    {
        List<ProductEntity> GetAll();
    }
}
