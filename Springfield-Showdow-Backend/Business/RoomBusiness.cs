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
    public class RoomBusiness : BaseBusiness<Room, RoomDto >, IRoomBusiness
    {
        private readonly IRoomData _roomData;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public RoomBusiness(IRoomData roomData, IMapper mapper, ILogger<RoomBusiness> logger) : base(roomData, mapper, logger)
        {
            _roomData = roomData;
            _mapper = mapper;
            _logger = logger;
        }

    }
}
