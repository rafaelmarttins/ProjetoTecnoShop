﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TecnoShop.Repository.Base
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T>? Browseable(Expression<Func<T, bool>>? predicate = null);

        IQueryable<T>? GetAll(int? take = null, int? skip = null);

        IQueryable<T>? Searchable(int? take = null, int? skip = null, Expression<Func<T, bool>>? predicate = null);

        T? GetById(object id);

        T? Insert(T obj);

        T? Update(T obj);

        T? Delete(object id);

        void Salve();
    }
}
