using Business.Interfaces;
using Entity.Dtos;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements;
using Web.Controllers.Interfaces;

namespace Web.Controller.Implements
{
    [Route("api/[controller]")]
    public class DeckController : BaseController<Deck, DeckDto>, IDeckController
    {
        protected readonly IDeckBusiness _business;
        public DeckController(IDeckBusiness business, ILogger<DeckController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(DeckDto dto)
        {
            return dto.Id;
        }

    }
}