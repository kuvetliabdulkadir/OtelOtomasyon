using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.entity_layer
{
    public class Customers
    {
        public int customerID;
        public string name;
        public string surname;
        public string phoneNumber;
        public string email;


        public int CustomerID { get => customerID; set => customerID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
