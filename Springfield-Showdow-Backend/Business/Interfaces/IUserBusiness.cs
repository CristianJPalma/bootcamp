using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.UserDto;
using Entity.Model;

namespace Business.Interfaces
{
    public interface IUserBusiness : IBaseBusiness<User, UserDto>
    {


        Task<User> LoginAsync(string email, string password);
        Task<bool> ValidateCredentialsAsync(string email, string password);
        Task<User> GetByEmailAsync(string email);
        
    }
}
