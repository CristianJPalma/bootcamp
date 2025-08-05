using Entity.Dtos.UserDto;
using Entity.Model;

namespace Web.Controllers.Interfaces
{ 
    public interface IUserController : IBaseController<User, UserDto>
    {

    }
}