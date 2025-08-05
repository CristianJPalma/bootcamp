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
    public class DeckBusiness : BaseBusiness<Deck, DeckDto>, IDeckBusiness
    {
        private readonly IDeckData _deckData;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public DeckBusiness(IDeckData deckData, IMapper mapper, ILogger<DeckBusiness> logger) : base(deckData, mapper, logger)
        {
            _deckData = deckData;
            _mapper = mapper;
            _logger = logger;
        }

    }
}
