using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway.Models.Models
{
    public class Base
    {
        [Key] public Guid Id { get; set; }
    }
}
