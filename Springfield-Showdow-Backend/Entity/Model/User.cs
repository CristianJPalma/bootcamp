using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.BaseDtos;
using Microsoft.SqlServer.Server;

namespace Entity.Model
{
    public class User : Base
    {
        public string EMail { get; set; }
        public string Password { get; set;}

        public Player Player { get; set; }





    }
}
