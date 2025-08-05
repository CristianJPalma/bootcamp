using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;
using Entity.Model;

namespace Entity.Dtos
{
    public class ShiftDto : BaseDto
    {

        public int RoundId { get; set; }
        public int PlayerShift { get; set; }
        public int CardSelect { get; set; }
    }
}
