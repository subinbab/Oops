using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
