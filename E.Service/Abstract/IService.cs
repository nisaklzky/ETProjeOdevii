﻿
using Et.Core.Entities;
using System.Linq.Expressions;


namespace Et.Service.Abstract
{
    public interface IService<T> where T : class, IEntity, new() 
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> GetQueryable();
        T Get(Expression<Func<T, bool>> expression);
        T Find(int Id);
        void Add (T entity);
        void Update (T entity);
        void Delete (T entity);
        int SaveChanges();
        //Asenkron metotlar
        Task<T> FindAsync(int Id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task <List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task<int> SaveChangesAsync();
    }

}