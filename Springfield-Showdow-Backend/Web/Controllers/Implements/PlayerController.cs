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
    public class PlayerController : BaseController<Player, PlayerDto>, IPlayerController
    {
        protected readonly IPlayerBusiness _business;
        public PlayerController(IPlayerBusiness business, ILogger<PlayerController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(PlayerDto dto)
        {
            return dto.Id;
        }
    }
}