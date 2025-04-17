using System;
using Entities;

namespace Data.Abstract;

public interface IUser
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetById(int id);
    Task AddAsync(User entity);
    Task UpdateAsync(User entity);
    Task DeleteAsync(User entity);

}
