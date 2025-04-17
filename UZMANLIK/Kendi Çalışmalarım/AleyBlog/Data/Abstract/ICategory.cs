using System;
using Entities;

namespace Data.Abstract;

public interface ICategory
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category> GetByAsync(int id);
    Task AddAsync(Category entity);
    Task UpdateAsync(Category entity);
    Task DeleteAsyn(Category entity);

}
