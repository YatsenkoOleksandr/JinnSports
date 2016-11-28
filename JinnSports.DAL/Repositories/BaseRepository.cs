﻿using System;
using System.Collections.Generic;
using System.Linq;
using JinnSports.DAL.EF;
using JinnSports.DataAccessInterfaces;
using System.Data.Entity;

namespace JinnSports.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    { 
        private DbSet<T> dbSet;

        public BaseRepository()
        {
            
        }

        public BaseRepository(DbSet<T> DbSet)
        {
            this.dbSet = DbSet;
        }

        public IList<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public void Add(T item)
        {
            dbSet.Add(item);
        }

        public void AddAll(T[] items)
        {
            dbSet.AddRange(items);
        }

        public void Remove(T item)
        {
            dbSet.Remove(item);
        }
    }
}
