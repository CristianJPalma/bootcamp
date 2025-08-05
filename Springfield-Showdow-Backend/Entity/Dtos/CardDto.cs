using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;

namespace Entity.Dtos
{
    public class CardDto : BaseDto
    {
        public string CardPicture { get; set; }

        public string Numbering { get; set; }

        public string CharacterName { get; set; }

        public int Intelligence { get; set; }

        public int Charm { get; set; }

        public int Strength { get; set; }

        public int Humor { get; set; }

        public int Chaos { get; set; }


    }
}
