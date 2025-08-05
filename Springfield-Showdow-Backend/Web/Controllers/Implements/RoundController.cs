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
    public class RoundController : BaseController<Round, RoundsDto>, IRoundController
    {
        protected readonly IRoundBusiness _business;
        public RoundController(IRoundBusiness business, ILogger<RoundController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(RoundsDto dto)
        {
            return dto.Id;
        }
    }
}