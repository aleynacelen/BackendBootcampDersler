using System;
using System.ComponentModel;

namespace Aleyna.Data.Abstract;

public interface ICategoryRepository: IGenericRepository<Category>
{ Task<IEnumarable<Category>> GetAllDeletedCategoriesAsync(); }

public interface IEnumarable<T>
{
}

public class Category
{
}