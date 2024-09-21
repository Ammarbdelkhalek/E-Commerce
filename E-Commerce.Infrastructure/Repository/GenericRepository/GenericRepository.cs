using E_Commerce.Core.Contracts.IGenericRepository;
using E_Commerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repository.GenericRepository
{
    public class GenericRepository<T>(ApplicationDbContext context) : IGenericRepository<T> where T : class
    {
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await context.Set<T>().AsNoTracking().ToListAsync();
            return result;  
        }

        public async Task<T> GetAsyncById(int id)
        {
            var result = await context.Set<T>().FindAsync(id);
            if(result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<T> GetByName(string Name)
        {
            var result = await context.Set<T>().FindAsync(Name);
            if (result == null)
            {
                return null;
            }
            return result;
        }
        public async Task<T> AddAsync(T entity)
        {
             var result  = await context.Set<T>().AddAsync(entity);
             await context.SaveChangesAsync();
             return entity; 
        }
        public async Task<T> UpdateAsync(T entity, int id)
        {

            var UpdatedItem = await GetAsyncById(id);
            context.Entry(entity).CurrentValues.SetValues(UpdatedItem);
            context.Entry(entity).State = EntityState.Modified;
           await context.SaveChangesAsync();
            if(UpdatedItem != null)
            {
                return UpdatedItem;
            }
            return null;

        }

        public async Task DeleteAsync(int id)
        {
            var result = await GetAsyncById(id);
             context.Set<T>().Remove(result);
            await context.SaveChangesAsync();
             
        }

       
    }
}
