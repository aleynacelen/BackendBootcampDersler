using System;
using Data.Abstract;
using Data.Context;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Concrate;

public class CategoryRepository : ICategory
{
    private  readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Category entity)
    {
        await _context.Categories.AddAsync(entity);
        await  _context.SaveChangesAsync();
    }

    public async Task DeleteAsyn(Category entity)
    {
        _context.Categories.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
       return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetByAsync(int id)
    {
        return await _context.Categories.FindAsync();
    }

    public async Task UpdateAsync(Category entity)
    {
      _context.Categories.Update(entity);
      await _context.SaveChangesAsync();
    }
}
