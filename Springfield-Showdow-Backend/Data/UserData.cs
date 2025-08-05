
using Data.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Dtos.UserDto;
using Entity.Model;
using Microsoft.Extensions.Configuration;
using BCrypt.Net;
using Data.Implements.BaseData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AutoMapper;

namespace Data.Implements.UserData
{
    public class UserData : BaseModelData<User, UserDto>, IUserData
    {

       private readonly ApplicationDbContext _context;
       private readonly IMapper _mapper;
       private readonly IConfiguration _configuration;


        public UserData(ApplicationDbContext context,  IConfiguration configuration, IMapper mapper) : base(context, configuration, mapper)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }


        // Este método LoginAsync se encarga de autenticar a un usuario. 

        public async Task<User> LoginAsync(string Email, string Password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.EMail == Email);
            if (user == null) return null;

            // Compara la contraseña ingresada con el hash almacenado
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(Password, user.Password);
            return isValidPassword ? user : null;
        }





    }
}
