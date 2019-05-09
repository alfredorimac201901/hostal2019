﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDorado.Data.Repository.Interface
{
    public interface IGeneriRepository <TEntity> where TEntity:class
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        int Count();
        TEntity GetById<TId>(TId id);
        List<TEntity> GetAll();

    }
}
