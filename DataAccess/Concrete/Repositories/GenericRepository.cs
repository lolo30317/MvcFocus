﻿using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        AppContext context=new AppContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Add(T t)
        {
            _object.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            _object.Remove(t);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
           
            context.SaveChanges();
        }
    }
}
