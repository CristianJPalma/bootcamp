using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Room : Base
    {
        public int participantsNumber { get; set; }
        public DateTime timePlayed { get; set; }
        public string result { get; set; }
        public ICollection<Round> Rounds { get; set; }
        public int PlayerId { get; set; }
        public ICollection<Player> Player { get; set; }


    }
}
