using System;
using Data.Abstract;
using Data.Context;
using Entities;

namespace Data.Concrate;

public class UserRepository : IUser
{
    private readonly AppDbContext _contex;

    public UserRepository(AppDbContext contex)
    {
        _contex = contex;
    }

    public Task AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }
}
