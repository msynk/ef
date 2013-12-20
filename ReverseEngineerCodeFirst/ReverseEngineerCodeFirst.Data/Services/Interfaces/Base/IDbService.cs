using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ReverseEngineerCodeFirst.Data.Services.Interfaces.Base
{
  public interface IDbService<T> where T : class
  {
    IQueryable<T> Query { get; }
    IQueryable<T> QueryForEdit { get; }

    IList<T> Get();
    IList<T> Get(Expression<Func<T, bool>> predicate);
    IList<T> Get(string path);
    IList<T> Get<TProperty>(Expression<Func<T, TProperty>> path);
    IList<T> Get(string path, Expression<Func<T, bool>> predicate);
    IList<T> Get<TProperty>(Expression<Func<T, TProperty>> path, Expression<Func<T, bool>> predicate);

    IList<T> GetForEdit();
    IList<T> GetForEdit(Expression<Func<T, bool>> predicate);
    IList<T> GetForEdit(string path);
    IList<T> GetForEdit<TProperty>(Expression<Func<T, TProperty>> path);
    IList<T> GetForEdit(string path, Expression<Func<T, bool>> predicate);
    IList<T> GetForEdit<TProperty>(Expression<Func<T, TProperty>> path, Expression<Func<T, bool>> predicate);

    T Add(T entity);
    void Edit(T entity);
    void Delete(T entity);
  }
}