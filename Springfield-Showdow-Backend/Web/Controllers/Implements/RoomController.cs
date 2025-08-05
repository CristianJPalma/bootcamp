using Business.Interfaces;
using Entity.Dtos;
using Entity.Dtos.UserDto;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements;
using Web.Controllers.Interfaces;

namespace Web.Controller.Implements
{
    [Route("api/[controller]")]
    public class RoomController : BaseController<Room, RoomDto>, IRoomController
    {
        protected readonly IRoomBusiness _business;
        public RoomController(IRoomBusiness business, ILogger<RoomController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(RoomDto dto)
        {
            return dto.Id;
        }

       





    }
}