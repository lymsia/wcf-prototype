using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedLib.Class
{
    public class user
    {
        public int id { get;set; }
        public string password { get; set; }
        public DateTime last_login { get; set; }
        public string email { get; set; }
        public int is_activate { get; set; }
        public int is_admin { get; set; }
    }
}
