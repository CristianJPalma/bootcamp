using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data.BaseData;
using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Dtos;
using Entity.Dtos.UserDto;
using Entity.Model;
using Microsoft.Extensions.Configuration;


namespace Data.Implements.PlayerData
{
    public class PlayerData : BaseModelData<Player, PlayerDto>, IPlayerData
    {
       

            private readonly ApplicationDbContext _context;
            private readonly IMapper _mapper;
            private readonly IConfiguration _configuration;


            public PlayerData(ApplicationDbContext context,   IConfiguration configuration, IMapper mapper) : base(context,  configuration, mapper)
            {
                _context = context;
               _mapper = mapper;
                _configuration = configuration;
            }

        }
    }

