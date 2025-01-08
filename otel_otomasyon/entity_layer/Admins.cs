using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.entity_layer
{
    public class Admins
    {
        public int adminID;
        public string name;
        public string surname;
        public string password;
        public string username;

        public int AdminID { get => adminID; set => adminID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }

    }
}
