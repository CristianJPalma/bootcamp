using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public abstract class Base
    {

        public int Id { get; set; }

        public bool Active  { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime DeleteAt { get; set; }
    }
}
