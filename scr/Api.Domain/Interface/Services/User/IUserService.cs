using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interface.Services.User
{
    public interface IUserService

    {
        Task<UserEntity> get(Guid id);
        Task<IEnumerable<UserEntity>> GatAll();
        Task<UserEntity> Post(UserEntity user);
        Task<UserEntity> Put(UserEntity user);
        Task<bool> Delete(Guid id);





    }
}