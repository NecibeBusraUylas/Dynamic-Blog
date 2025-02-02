﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using (var c = new Context())
            {
                return filter == null ?
                    c.Set<T>().ToList() :
                    c.Set<T>().Where(filter).ToList();
            }
        }

        public T GetByFilter(Expression<Func<T, bool>> filter = null)
        {
            using var c = new Context();
            if (filter == null)
                return c.Set<T>().FirstOrDefault();
            else
                return c.Set<T>().FirstOrDefault(filter);
            //return c.Set<T>().Where(filter).FirstOrDefault();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }

        public int GetCount(Expression<Func<T, bool>> filter = null)
        {
            using var c = new Context();
            if (filter == null)
                return c.Set<T>().Count();
            else
                return c.Set<T>().Where(filter).Count();
        }
    }
}