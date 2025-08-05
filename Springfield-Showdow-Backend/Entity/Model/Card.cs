using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entity.Model
{
    public  class Card : Base
    {
        public string CardPicture { get; set; }

        public string Numbering { get; set; }

        public string CharacterName { get; set; }    

        public int Intelligence { get; set; }

        public int Charm { get; set; }

        public int Strength { get; set; }

        public int Humor { get; set; }

        public int Chaos { get; set; }

        public ICollection<Deck> Decks { get; set; }

    }
}
