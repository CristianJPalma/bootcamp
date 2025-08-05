using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Shift : Base
    {
        public int RoundId { get; set; }
        public Round Round { get; set; }
        public int PlayerShift { get; set; }
        public int CardSelect {  get; set; }


    }
}
