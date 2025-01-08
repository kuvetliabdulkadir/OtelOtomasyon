using otel_otomasyon.business_layer;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace otel_otomasyon.presentation_layer
{
    public partial class musteri_duzenle_form : Form
    {

        private Customers _customer;
        private CustomerBLL _customerBLL;
        public musteri_duzenle_form(Customers customersDetails)
        {
            InitializeComponent();
           _customer = new Customers();
           _customerBLL = new CustomerBLL();
           _customer = customersDetails;
        }
            
        private void musteri_duzenle_form_Load(object sender, EventArgs e)
        {
            mstridtxt.Text = _customer.CustomerID.ToString();
            mstradtxt.Text = _customer.Name;
            mstrsoyadtxt.Text = _customer.Surname;
            mstrteltxt.Text = _customer.PhoneNumber;
            mstremailtxt.Text = _customer.Email;
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



        private void mstrguncellebtn_Click(object sender, EventArgs e)
        {
            string email = mstremailtxt.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string phoneNumber = mstrteltxt.Text;
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz (11 haneli, sadece rakam).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            _customer.Name = mstradtxt.Text;
            _customer.Surname = mstrsoyadtxt.Text;
            _customer.PhoneNumber = phoneNumber;
            _customer.Email = email;

            bool isUpdated = _customerBLL.UpdateCustomer(_customer);
            if (isUpdated)
            {
                MessageBox.Show("Müşteri başarıyla güncellendi.");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Müşteri güncellenemedi.");
            }
        }

        
    }
}

