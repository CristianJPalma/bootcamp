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
    public class ShiftProfile : Profile
    {
        public ShiftProfile() {


            CreateMap<ShiftDto, Shift>().ReverseMap();
        }
    }
}
