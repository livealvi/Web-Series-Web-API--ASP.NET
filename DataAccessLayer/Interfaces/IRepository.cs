﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T, ID>
    {
        List<T> Get();
        T Get(ID id);
        void Create(T obj);
        void Update(T obj);
        void Delete(ID id);
    }
}