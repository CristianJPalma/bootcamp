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
    public class ShiftController : BaseController<Shift, ShiftDto>, IShiftController
    {
        protected readonly IShiftBusiness _business;
        public ShiftController(IShiftBusiness business, ILogger<ShiftController> logger) : base(business, logger)
        {
            _business = business;
        }
        
        protected override int GetEntityId(ShiftDto dto)
        {
            return dto.Id;
        }
    }
}