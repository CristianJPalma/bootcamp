using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.BaseBusiness;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos.UserDto;
using Entity.Model;
using Microsoft.Extensions.Logging;

namespace Business
{
    public class UserBusiness : BaseBusiness<User, UserDto>, IUserBusiness
    {
        private readonly IUserData _userData;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UserBusiness(IUserData userData, IMapper mapper, ILogger<UserBusiness> logger) : base(userData, mapper, logger)
        {
            _userData = userData;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Crea un nuevo usuario con la contraseña hasheada.
        /// </summary>
        public override async Task<UserDto> CreateAsync(UserDto dto)
        {
            if (!string.IsNullOrWhiteSpace(dto.Password))
            {
                dto.Password = HashPassword(dto.Password);
            }

            return await base.CreateAsync(dto);
        }

        /// <summary>
        /// Inicia sesión validando las credenciales del usuario.
        /// </summary>
        public async Task<User> LoginAsync(string email, string password)
        {
            var user = await GetByEmailAsync(email);
            if (user == null || !user.Active)
            {
                _logger.LogWarning("Login fallido: usuario no encontrado o inactivo. Email: {email}", email);
                return null;
            }

            string hashedPassword = HashPassword(password);
            if (user.Password != hashedPassword)
            {
                _logger.LogWarning("Login fallido: contraseña incorrecta para el usuario {email}", email);
                return null;
            }

            return user;
        }

        /// <summary>
        /// Valida si las credenciales del usuario son correctas.
        /// </summary>
        public async Task<bool> ValidateCredentialsAsync(string email, string password)
        {
            var user = await LoginAsync(email, password);
            return user != null;
        }

        /// <summary>
        /// Hashea una contraseña en texto plano con SHA-256 y Base64.
        /// </summary>
        private string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        /// Busca un usuario por su correo electrónico.
        /// </summary>
        public async Task<User> GetByEmailAsync(string email)
        {
            var users = await _userData.GetAllAsync();
            return users.FirstOrDefault(u => u.EMail.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}



