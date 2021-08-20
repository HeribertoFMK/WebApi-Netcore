using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;



namespace Api.Domain.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(T item);
        Task<T> SelectAsync(Guid Id);
        Task<IEnumerable<T>> SelectAsync();






    }
}