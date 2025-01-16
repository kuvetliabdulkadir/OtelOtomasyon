using otel_otomasyon.business_layer;
using otel_otomasyon.dataaccess_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon.presentation_layer
{
    public partial class musteri_yonetimi_form : Form
    {
        private CustomerBLL _customerBLL;
        

        public musteri_yonetimi_form()
        {
            InitializeComponent();
            _customerBLL = new CustomerBLL();
        }


        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void musteri_yonetimi_form_Load(object sender, EventArgs e)
        {
            try
            {
                var customerData = _customerBLL.GetCustomer();
                mstrDataGridView.DataSource = customerData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Control control in mstrkayitgrpbox.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Tag = textBox.Text;
                    textBox.Enter += TextBox_Enter;
                    textBox.Leave += TextBox_Leave;
                }
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void mstrgoruntulebtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                var customerData = _customerBLL.GetCustomer();
                mstrDataGridView.DataSource = customerData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mstrsilbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (mstrDataGridView.SelectedRows.Count > 0)
                {

                    int customerID = Convert.ToInt32(mstrDataGridView.SelectedRows[0].Cells["CustomerID"].Value);


                    DialogResult dialogResult = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?",
                        "Müşteri Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {

                        if (_customerBLL.DeleteCustomer(customerID))
                        {
                            MessageBox.Show("Müşteri başarıyla silindi!");


                            var roomData = _customerBLL.GetCustomer();
                            mstrDataGridView.DataSource = roomData;
                        }
                        else
                        {
                            MessageBox.Show("Müşteri silinemedi.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mstrkayitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = mstradtxt.Text.Trim();
                string surname = mstrsoyadtxt.Text.Trim();
                string email = mstrmailtxt.Text.Trim();
                string phoneNumber = mstrteltxt.Text.Trim();

                if (_customerBLL.AddCustomer(name, surname, email, phoneNumber))
                {
                    MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var roomData = _customerBLL.GetCustomer();
                    mstrDataGridView.DataSource = roomData;

                    foreach (Control control in mstrkayitgrpbox.Controls)
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.Text = textBox.Tag.ToString();
                            textBox.ForeColor = Color.Gray;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            yonetici_islemleri_form yonetici_İslemleri_Form = new yonetici_islemleri_form();
            yonetici_İslemleri_Form.Show();
            this.Hide();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rzvyonlendirbtn_Click(object sender, EventArgs e)
        {
            if (mstrDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!");
                return;
            }

            int customerID = Convert.ToInt32(mstrDataGridView.SelectedRows[0].Cells["CustomerID"].Value);

            var rezervasyonForm = new rezervasyon_yonetimi(customerID);
            if (rezervasyonForm.ShowDialog() == DialogResult.OK)
            {
                
                MessageBox.Show("Rezervasyon işlemi tamamlandı!");
            }
        }

        private void LoadCustomers()
        {
            var customers = _customerBLL.GetCustomer();
            mstrDataGridView.DataSource = customers;
        }


        private void mstrduzenlebtn_Click(object sender, EventArgs e)
        {
            if (mstrDataGridView.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(mstrDataGridView.SelectedRows[0].Cells["CustomerID"].Value);
                var customerDetails = _customerBLL.GetCustomerDetails(customerId);

                musteri_duzenle_form musteri_Duzenle_Form =new musteri_duzenle_form(customerDetails);
                musteri_Duzenle_Form.ShowDialog();

                LoadCustomers();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz müşteriyi seçin.");
            }
        }

        private void olusturulanrznbtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (mstrDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir müşteri seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedCustomerID = Convert.ToInt32(mstrDataGridView.SelectedRows[0].Cells["CustomerID"].Value);

                musteri_rezervasyon_form rezervasyonlarForm = new musteri_rezervasyon_form(selectedCustomerID);
                rezervasyonlarForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
