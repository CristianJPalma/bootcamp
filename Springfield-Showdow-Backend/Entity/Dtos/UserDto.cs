using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model;
using Entity.Dtos.BaseDtos;

namespace Entity.Dtos.UserDto
{
    public class UserDto : BaseDto
    {

        public string Email { get; set; }
        public string Password { get; set; }


    }
}
