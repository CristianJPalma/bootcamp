
using AutoMapper;
using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Dtos;
using Entity.Model;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class CardData : BaseModelData<Card, CardDto>, ICardData
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper; 

        public CardData(ApplicationDbContext context, IConfiguration configuration, IMapper mapper) : base(context, configuration, mapper)
        { 
        _configuration = configuration;
        _context = context;
        _mapper = mapper;
        
        }
    }
}
