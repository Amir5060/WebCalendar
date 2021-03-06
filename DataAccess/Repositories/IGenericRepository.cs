﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        Task<dynamic> Add(TEntity entity);
        void Delete(TEntity entity);
        Task<dynamic> Update(TEntity entity);
    }
}
