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
    public class RoundBusiness : BaseBusiness<Round, RoundsDto>, IRoundBusiness
    {
        private readonly IRoundData _roundData;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public RoundBusiness(IRoundData roundData, IMapper mapper, ILogger<RoundBusiness> logger) : base(roundData, mapper, logger)
        {
            _roundData = roundData;
            _mapper = mapper;
            _logger = logger;
        }


    }
}
