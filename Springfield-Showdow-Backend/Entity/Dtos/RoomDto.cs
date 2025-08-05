using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model;
using Entity.Dtos.BaseDtos;

namespace Entity.Dtos
{
    public class RoomDto : BaseDto
    {
        public int ParticipantsNumber { get; set; }
        public DateTime? TimePlayed { get; set; }
        public bool IsActive { get; set; }
        public string Result { get; set; }
    }
}
