using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity.Dtos;
using Entity.Model;

namespace Utilitis.Mappers
{
    public class CardProfile : Profile
    {

        public CardProfile() {
            CreateMap<CardDto, Card>().ReverseMap();
        }
    }
}
