using System;
using Entities;

namespace Data.Abstract;

public interface IPost
{
    Task<IEnumerable<Post>> GetAllAsync();
    Task<Post> GetByIdAsync(int id);
    Task AddAsync(Post entity);
    Task UpdateAsync(Post entity);
    Task DeleteAsync(Post entity);
    

}
