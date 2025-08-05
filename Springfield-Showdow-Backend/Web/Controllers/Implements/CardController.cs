using Business.Interfaces;
using Entity.Dtos;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements;
using Web.Controllers.Interfaces;

 namespace Web.Controller.Implements
 {
    [Route("api/[controller]")]
    public class CardController : BaseController<Card, CardDto>, ICardController
    {
        protected readonly ICardBusiness _business;
        public CardController(ICardBusiness business, ILogger<CardController> logger) : base(business, logger)
        {
            _business = business;
        }

        protected override int GetEntityId(CardDto dto)
        {
            return dto.Id;
        }

    }
}