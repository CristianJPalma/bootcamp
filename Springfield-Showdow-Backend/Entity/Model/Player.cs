using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Player : Base
    {
        public int UserId { get; set; }
        public User Users { get; set; }
        public Room Room { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
        public ICollection<Deck> Decks { get; set; }
      


    }
}
