using Business.Interfaces;
using Business.Services;
using Entity.Dtos;
using Entity.Dtos.UserDto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements;
using Web.Controllers.Interfaces;

namespace Web.Controller.Implements
{
    [Route("api/[controller]")]
    public class UserController : BaseController<User, UserDto>, IUserController
    {
        protected readonly IUserBusiness _business;
        
        public UserController(IUserBusiness business, ILogger<UserController> logger) : base(business, logger)
        {
            _business = business;
            
        }

        protected override int GetEntityId(UserDto dto)
        {
            return dto.Id;
        }


    }
}