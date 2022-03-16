﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        List<Product> GetListById(int id);
        void ProductAdd(Product product);
        void ProductDelete(Product product);
        void ProductUpdate(Product product);
        Product GetById(int id);
    }
}
