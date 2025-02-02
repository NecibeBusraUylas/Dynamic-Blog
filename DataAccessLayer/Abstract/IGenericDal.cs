﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
        T GetByFilter(Expression<Func<T, bool>> filter = null);
        int GetCount(Expression<Func<T, bool>> filter = null);
    }
}