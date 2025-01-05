using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace EShop.Data.Abstract;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetAsync(int[] id);//tek bir veri getirir
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate=null, params Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>[] includes//tek bir veri getirir ve include eder ve filtreler 
  );
  Task<IEnumerable<TEntity>> GetAllAsync();//tüm verileri getirir
  Task<IEnumerable<TEntity>>GetAllAsync( Expression<Func<TEntity,bool>> predicate=null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>ordery=null,params Func<IQueryable<TEntity>,IQueryable<TEntity>>[] includes);//tüm verileri getirir  ve include eder ve filtreler v
  Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate); //var olup olmadığını kontrol eder
  Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null);//kaç tane var
 Task<TEntity> AddAsync(TEntity entity);//ekleme
  void Update(TEntity entity);//güncelleme
    void Delete(TEntity entity);//silme
   
}
