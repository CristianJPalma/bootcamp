using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.BaseBusiness;
using Business.Interfaces;
using Data.Implements.BaseData;
using Data.Implements.PlayerData;
using Data.Implements.UserData;
using Data.Interfaces;
using Entity.Dtos;
using Entity.Dtos.UserDto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business
{
    public  class PlayerBusiness : BaseBusiness<Player, PlayerDto>, IPlayerBusiness
    {
        private readonly IPlayerData _playerData;
        private readonly IMapper _mapper;
        private readonly ILogger _logger; 


        public PlayerBusiness(IPlayerData playerData, IMapper mapper, ILogger<PlayerBusiness> logger) : base(playerData, mapper, logger) 
        {
            _playerData = playerData;
            _mapper = mapper;
            _logger = logger;
        }

    }

}
