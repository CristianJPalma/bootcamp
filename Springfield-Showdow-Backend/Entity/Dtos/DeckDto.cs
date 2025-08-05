using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;
using Entity.Model;

namespace Entity.Dtos
{
    public class DeckDto : BaseDto
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }

    }
}
