using FinanceCoreX.Core.Entities;
using FinanceCoreX.Services.Dtos;
using FinanceCoreX.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceCoreX.Services.Abstract
{
    public interface IUserService
    {
        Task<Response<UserDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<User>> GetUserByNameAsync(string userName);
    }
}
