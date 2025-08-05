using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;
using Entity.Model;

namespace Entity.Dtos
{
    public class PlayerDto : BaseDto
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
       






    }
}
