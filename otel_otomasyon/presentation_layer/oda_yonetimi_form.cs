using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using otel_otomasyon.dataaccess_layer;
using otel_otomasyon.business_layer;
using System.Drawing;

namespace otel_otomasyon.presentation_layer
{

    public partial class oda_yonetimi_form : Form
    {
        private RoomBLL _roomBLL;

        public oda_yonetimi_form()
        {
            InitializeComponent();
            _roomBLL = new RoomBLL();
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();


        }
        private void oda_yonetimi_form_Load(object sender, EventArgs e)
        {
            try
            {
                var roomData = _roomBLL.GetRooms();
                odaDataGridView.DataSource = roomData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Control control in odaeklegrpbox.Controls)
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

        public void odaeklebtn_Click(object sender, EventArgs e)
        {
            try 
            {
               
                int roomNumber = int.Parse(odanumaratxt.Text); 
                string roomType = odatipitxt.Text;  
                decimal dailyPay = decimal.Parse(odafiyattxt.Text);
                string status = odadurumtxt.Text.ToString(); 

                
                if (_roomBLL.AddRoom(roomNumber, roomType, dailyPay, status))
                {
                    MessageBox.Show("Oda başarıyla eklendi!");
                    foreach (Control control in odaeklegrpbox.Controls)
                    {
                        var roomData = _roomBLL.GetRooms();
                        odaDataGridView.DataSource = roomData;
                        if (control is TextBox textBox)
                        {
                            textBox.Text = textBox.Tag.ToString();
                            textBox.ForeColor = Color.Gray;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Oda maalesef eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void geribtn_Click(object sender, EventArgs e)
        {
            yonetici_islemleri_form yonetici_İslemleri_Form = new yonetici_islemleri_form();
            yonetici_İslemleri_Form.Show();
            this.Hide();

        }

        

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = odaDataGridView.SelectedCells[0].RowIndex;
            //odanumaratxt.Text = odaDataGridView.Rows[secilen].Cells[1].Value.ToString();
            //odatipitxt.Text = odaDataGridView.Rows[secilen].Cells[2].Value.ToString();
            //odadurumtxt.Text = odaDataGridView.Rows[secilen].Cells[3].Value.ToString();
            //odafiyattxt.Text = odaDataGridView.Rows[secilen].Cells[4].Value.ToString();
            
        }

        public void odagoruntulebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var roomData = _roomBLL.GetRooms();
                odaDataGridView.DataSource = roomData; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void odasilbtn_Click(object sender, EventArgs e)
        {

            try
            {
               
                if (odaDataGridView.SelectedRows.Count > 0)
                {
                    
                    int roomID = Convert.ToInt32(odaDataGridView.SelectedRows[0].Cells["RoomID"].Value);

                  
                    DialogResult dialogResult = MessageBox.Show("Bu odayı silmek istediğinize emin misiniz?",
                        "Oda Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        if (_roomBLL.DeleteRoom(roomID))
                        {
                            MessageBox.Show("Oda başarıyla silindi!");

                           
                            var roomData = _roomBLL.GetRooms();
                            odaDataGridView.DataSource = roomData;
                        }
                        else
                        {
                            MessageBox.Show("Oda silinemedi.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz odanın satıtırını  seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void odauygunbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (odaDataGridView.SelectedRows.Count > 0)
                {
                    int roomID = Convert.ToInt32(odaDataGridView.SelectedRows[0].Cells["RoomID"].Value);
                    string currentStatus = odaDataGridView.SelectedRows[0].Cells["Status"].Value.ToString();

                    
                    string newStatus = currentStatus == "Available" ? "Unavailable" : "Available";

                   
                    DialogResult dialogResult = MessageBox.Show(
                        $"Odanın durumunu '{currentStatus}' yerine '{newStatus}' yapmak istediğinize emin misiniz?",
                        "Durum Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (_roomBLL.UpdateRoomStatus(roomID, newStatus))
                        {
                            MessageBox.Show("Oda durumu başarıyla güncellendi!");

                            var roomData = _roomBLL.GetRooms();
                            odaDataGridView.DataSource = roomData;
                        }
                        else
                        {
                            MessageBox.Show("Oda durumu güncellenemedi.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen durumunu değiştirmek istediğiniz odanın satırını seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void odaduzenlebtn_Click(object sender, EventArgs e)
        {
            if (odaDataGridView.SelectedRows.Count > 0)
            {
                int roomId = Convert.ToInt32(odaDataGridView.SelectedRows[0].Cells["RoomID"].Value);

                var roomDetails = _roomBLL.GetRoomDetails(roomId);

                oda_duzenle_form odaDuzenleForm = new oda_duzenle_form(roomDetails);
                odaDuzenleForm.ShowDialog();

                LoadRooms();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz odayı seçin.");
            }
        }

        private void LoadRooms()
        {
            var rooms = _roomBLL.GetRooms();
            odaDataGridView.DataSource = rooms;
        }

        private void odadurumtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}