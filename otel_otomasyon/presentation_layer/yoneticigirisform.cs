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
using System.Data.Common;
using MySql.Data.MySqlClient;
using otel_otomasyon.business_layer;


namespace otel_otomasyon.presentation_layer
{
    public partial class yoneticigirisform : Form
    {

        private AdminBLL _adminBLL;


        public yoneticigirisform()
        {
            InitializeComponent();
            _adminBLL = new AdminBLL();
        }
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void yoneticigirisform_Load(object sender, EventArgs e)
        {

            foreach (Control control in yntgirisgrpbox.Controls)
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

        private void geribtn_Click(object sender, EventArgs e)
        {
          otel_giris_form otel_Giris_Form = new otel_giris_form();
          otel_Giris_Form.Show();
            this.Hide();
        }

        private void yntgirisbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = yntkullaniciaditxt.Text;
                string password = yntparolatxt.Text;

                if (_adminBLL.oturumdogrula(username, password))
                {
                    yonetici_islemleri_form yonetici_islemleri = new yonetici_islemleri_form();
                    yonetici_islemleri.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
