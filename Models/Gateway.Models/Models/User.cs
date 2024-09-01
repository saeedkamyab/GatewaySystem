using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway.Models.Models
{
    public class User:Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
