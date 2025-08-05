using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Entity.Model
{
    public  class Round : Base
    {
       
        public int RoomId { get; set; }
        public Room Rooms { get; set; }
        public string winner { get; set; }
        public string selectedAttribute { get; set; }
        public ICollection<Shift> Shifts { get; set; }


    }
}
