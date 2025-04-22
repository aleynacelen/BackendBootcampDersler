using System;
using Data.Abstract;
using Data.Context;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Concrate;

public class PostRepository : IPost
{
    private readonly AppDbContext _context;

    public PostRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Post entity)
    {
         await _context.Posts.AddAsync(entity);
        
    }

    public async Task DeleteAsync(Post entity)
    {
        _context.Posts.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Post>> GetAllAsync()
    {
        return await _context.Posts.ToListAsync();

    }

    public async Task<Post> GetByIdAsync(int id)
    {
        return await _context.Posts.FindAsync();
    }

    public async Task UpdateAsync(Post entity)
    {
         _context.Posts.Update(entity);
         return; 
         async;
        
    }
}
