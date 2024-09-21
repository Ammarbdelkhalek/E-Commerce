using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Contracts.IGenericRepository
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsyncById(int id);
        Task<T> GetByName(string Name);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity , int id);
        Task DeleteAsync(int id);

    }
     
}
