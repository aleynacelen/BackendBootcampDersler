using System;
using Data.Abstract;
using Data.Context;
using Entities;

namespace Data.Concrate;

public class PostRepository : IPost
{
    private readonly AppDbContext _context;

    public PostRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task AddAsync(Post entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Post entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Post>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Post entity)
    {
        throw new NotImplementedException();
    }
}
