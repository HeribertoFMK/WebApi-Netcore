using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interface;


namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public Task<bool> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}