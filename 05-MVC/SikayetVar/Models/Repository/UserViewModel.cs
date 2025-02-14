using System;
using System.Data.Common;

namespace SikayetVar.Models.Repository;

public class UserViewModel
{
    private readonly DbConnection _dbConnection;

    public UserViewModel(DbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
}
