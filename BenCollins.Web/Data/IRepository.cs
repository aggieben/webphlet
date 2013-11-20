﻿using BenCollins.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BenCollins.Web.Data
{
    interface IRepository<T> where T : ModelBase
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T FindBySid(Guid id);
        T FindById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll();
    }
}