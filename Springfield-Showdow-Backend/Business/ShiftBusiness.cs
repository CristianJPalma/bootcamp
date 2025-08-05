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
    public class ShiftBusiness : BaseBusiness<Shift, ShiftDto>, IShiftBusiness
    {
        private readonly IShiftData _shiftData;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public ShiftBusiness(IShiftData shiftData, IMapper mapper, ILogger<ShiftBusiness> logger) : base(shiftData, mapper, logger)
        {
            _shiftData = shiftData;
            _mapper = mapper;
            _logger = logger;
        }

    }
}
