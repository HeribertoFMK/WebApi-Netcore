using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dbset;

        public BaseRepository(MyContext myContext)
        {
            myContext = _context;
            _dbset = _context.Set<T>();





        }
        public Task<bool> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();


                }
                item.CreatAt = DateTime.UtcNow;
                _dbset.Add(item);
                await _context.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                throw ex;


            }

            return item;

        }

        public Task<T> SelectAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T item)
        {
            item.CreatAt = DateTime.UtcNow;
            var result = await _dbset.SingleOrDefaultAsync(p => p.Id.Equals(p.Id));
            if (result == null)
                return null;
            item.CreatAt = result.CreatAt;

            try
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;

        }
    }
}