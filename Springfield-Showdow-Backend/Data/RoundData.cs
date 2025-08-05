using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Dtos;
using Entity.Model;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class RoundData : BaseModelData<Round, RoundsDto>, IRoundData 

    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper; 

        public RoundData(ApplicationDbContext context, IConfiguration configuration, IMapper mapper) : base(context, configuration, mapper)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }
    }
}
