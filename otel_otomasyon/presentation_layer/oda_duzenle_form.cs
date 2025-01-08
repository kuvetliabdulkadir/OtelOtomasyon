using otel_otomasyon.business_layer;
using otel_otomasyon.dataaccess_layer;
using otel_otomasyon.entity_layer;
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
    public partial class oda_duzenle_form : Form
    {
        private RoomBLL _roomBLL;
        private RoomDAL _roomDAL;
        private Rooms _roomDetails;

        public oda_duzenle_form(Rooms roomDetails)
        {
            InitializeComponent();
            _roomBLL = new RoomBLL();
            _roomDAL = new RoomDAL();
            _roomDetails = roomDetails;
            
        } 
        private void oda_duzenle_form_Load(object sender, EventArgs e)
        {

            odaidtxt.Text = _roomDetails.RoomID.ToString();
            odanumaratxt.Text = _roomDetails.RoomNumber.ToString();
            odatiptxt.Text = _roomDetails.RoomType;
            odafiyattxt.Text = _roomDetails.dailyPay.ToString();
            odadurumtxt.Text = _roomDetails.Status;

        }

        private void odaguncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int roomID = Convert.ToInt32(odaidtxt.Text);  
                int roomNumber = Convert.ToInt32(odanumaratxt.Text);  
                string roomType = odatiptxt.Text;
                decimal dailyPay = Convert.ToDecimal(odafiyattxt.Text);
                string status = odadurumtxt.Text; 

                if (_roomBLL.IsRoomNumberExists(roomNumber, roomID))
                {
                    MessageBox.Show("Bu oda numarası zaten kullanılıyor. Lütfen farklı bir oda numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var room = new Rooms
                {
                    RoomID = roomID,  
                    RoomNumber = roomNumber,  
                    RoomType = roomType,
                    DailyPay = dailyPay,
                    Status = status
                };

                bool success = _roomBLL.UpdateRoom(room);

                if (success)
                {
                    MessageBox.Show("Oda başarıyla güncellendi.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Oda güncellenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
