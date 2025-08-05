using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Implements.BaseData;
using Entity.Dtos.UserDto;
using Entity.Model;

namespace Data.Interfaces
{
    public interface IUserData : IBaseModelData<User, UserDto>
    {
        
        Task<User> LoginAsync(string email, string password);
      
       
    }
}
