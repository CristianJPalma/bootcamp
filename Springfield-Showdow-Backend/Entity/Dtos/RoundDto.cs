using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model;
using Entity.Dtos.BaseDtos;

namespace Entity.Dtos
{
    public class RoundsDto : BaseDto
    {
        public int RoomId { get; set; }
        public int Winner { get; set; }
        public string SelectedAttribute { get; set; }



    }
}
