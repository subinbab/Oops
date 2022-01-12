using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Create
    {
        [Key]
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }

    }
}
