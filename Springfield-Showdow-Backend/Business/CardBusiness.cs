using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.BaseBusiness;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business
{
    public class CardBusiness : BaseBusiness<Card, CardDto>, ICardBusiness
    {
        private readonly ICardData _cardData;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public CardBusiness(ICardData cardData, IMapper mapper, ILogger<CardBusiness> logger) : base(cardData, mapper, logger)
        {
            _cardData = cardData;
            _mapper = mapper;
            _logger = logger;
        }


    }
}
