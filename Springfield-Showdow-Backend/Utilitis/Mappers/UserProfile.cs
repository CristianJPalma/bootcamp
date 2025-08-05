using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity.Dtos.UserDto;
using Entity.Model;

namespace Utilitis.Mappers
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<UserDto, User>()
    .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password)) // ✅ copia el valor
    .ReverseMap();

        }
    }
}
