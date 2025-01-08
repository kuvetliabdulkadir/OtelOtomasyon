using otel_otomasyon.dataaccess_layer;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace otel_otomasyon.business_layer
{
    public class CustomerBLL
    {
        private CustomerDAL _customerDAL;

        public CustomerBLL()
        {
            _customerDAL = new CustomerDAL();
        }


        public bool AddCustomer(string name, string surname, string email, string phoneNumber)
        {
            
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phoneNumber)|| name == "Adınız" || surname == "Soyadınız"|| email == "E-posta" || phoneNumber == "Telefon Numaranız")
            {
                throw new Exception("Tüm alanlar doldurulmalıdır.");
            }

           
            if (!IsValidEmail(email))
            {
                throw new Exception("Geçerli bir e-posta adresi giriniz.");
            }

           
            if (!IsValidPhoneNumber(phoneNumber))
            {
                throw new Exception("Geçerli bir telefon numarası giriniz.");
            }

          
            return _customerDAL.AddCustomer(name, surname, email, phoneNumber);
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
           
            return Regex.IsMatch(phoneNumber, @"^\d{11}$"); 
        }

        public DataTable GetCustomer()
        {
            return _customerDAL.GetCustomer();
        }

        public bool DeleteCustomer(int customerID)
        {
            return _customerDAL.DeleteCustomer(customerID);
        }


        public bool UpdateCustomer(Customers customer)
        {
            return _customerDAL.UpdateCustomer(customer);
        }
        public Customers GetCustomerDetails(int customerID)
        {
            return _customerDAL.GetCustomerDetails(customerID);
        }
    }
}
