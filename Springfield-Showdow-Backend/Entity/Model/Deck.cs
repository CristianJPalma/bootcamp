using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Deck : Base
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }



    }
}
