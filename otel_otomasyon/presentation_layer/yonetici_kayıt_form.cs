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
using System.Xml.Linq;

namespace otel_otomasyon.presentation_layer
{
    public partial class yonetici_kayıt_form : Form
    {
        public yonetici_kayıt_form()
        {
            InitializeComponent();
            adminBLL = new AdminBLL();

        }
        private AdminBLL adminBLL;

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void yntkayitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = yntkayitkullaniciadtxt.Text.Trim();
                string password = yntkayitparolatxt.Text.Trim();
                string name = yntkayitadtxt.Text.Trim();
                string surname = yntkayitsoyadtxt.Text.Trim();

                if (adminBLL.AddAdmin(username, password, name, surname))
                {
                    MessageBox.Show("Yönetici başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    DataTable adminsTable = adminBLL.GetAdmins();
                    yntDataGridView.DataSource = adminsTable;
                    
                    foreach (Control control in yntkayitgrpbox.Controls)
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
                    MessageBox.Show("Yönetici eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void yonetici_kayıt_form_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable adminsTable = adminBLL.GetAdmins();
                yntDataGridView.DataSource = adminsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Control control in yntkayitgrpbox.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Tag = textBox.Text;
                    textBox.Enter += TextBox_Enter;
                    textBox.Leave += TextBox_Leave;
                }
            }
        }

        private void yntgoruntulebtn_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable adminsTable = adminBLL.GetAdmins();
                yntDataGridView.DataSource = adminsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yntsilbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (yntDataGridView.SelectedRows.Count > 0)
                {
                    int adminID = Convert.ToInt32(yntDataGridView.SelectedRows[0].Cells["AdminID"].Value);

                    DialogResult dialogResult = MessageBox.Show(
                        "Bu yöneticiyi silmek istediğinize emin misiniz?",
                        "Yöneticiyi Sil",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (adminBLL.DeleteAdmin(adminID))
                        {
                            MessageBox.Show("Yönetici başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DataTable adminsTable = adminBLL.GetAdmins();
                            yntDataGridView.DataSource = adminsTable;
                        }
                        else
                        {
                            MessageBox.Show("Yönetici silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz yöneticiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void yntkayitgrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yntduzzenlebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
