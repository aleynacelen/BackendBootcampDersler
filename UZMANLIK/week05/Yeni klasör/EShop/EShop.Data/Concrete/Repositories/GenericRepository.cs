using System;
using System.Linq.Expressions;
using EShop.Data.Abstract;
using EShop.Data.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly EShopDbContext _dBcontext;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(EShopDbContext dBcontext)
    {
        _dBcontext = dBcontext;
        _dbSet= _dBcontext.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
    {
       return await _dbSet.CountAsync(predicate);//predicate verilen koşula uyan kayıt sayısını döndürür
    }

    public void Delete(TEntity entity)
    {
      _dbSet.Remove(entity);    
    }

    public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate) //amaç veri tabanında var mı yok mu kontrol etmek
    {
       return await _dbSet.AnyAsync(predicate); //predicate verilen koşula uyan kayıt var mı yok mu kontrol eder
    }
 

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> ordery = null, params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes)
    {
      IQueryable<TEntity> query = _dbSet;
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        if (includes != null)
        {
            query = includes.Aggregate(query, (current, include) => include(current));
        }
        return await query.ToListAsync();
    }

    public async Task<TEntity> GetAsync(int[] id)
    {
        return  await _dbSet.FindAsync(id);

    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>[] includes)
    {
        IQueryable<TEntity> query = _dbSet;
        if (predicate != null)
        {
            query = query.Where(predicate);

        }
       
       if (includes != null)
        {
            query = includes.Aggregate(query, (current, include) => include(current));//bana şöyle bir sonuç döndür current=>include(current)
        }
       var result = await query.FirstOrDefaultAsync();
       return result;
    }

    public void Update(TEntity entity)
    {
       _dbSet.Update(entity);

    }
}

#region açık
//_dbSet=context.Product
//query=context.Product
//predicate=p=>p.Id==1
//query=context.Product.Where(p=>p.Id==1)

#endregion
