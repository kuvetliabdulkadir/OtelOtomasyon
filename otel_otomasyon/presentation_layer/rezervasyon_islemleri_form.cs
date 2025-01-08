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
    public partial class rezervasyon_islemleri_form : Form
    {

        private ReservationBLL _reservationBLL;
        private ReservationDAL _reservationDAL;
      
        public rezervasyon_islemleri_form()
        {
            InitializeComponent();
            _reservationBLL = new ReservationBLL();
            _reservationDAL = new ReservationDAL();

        }
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void rzvsilbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (rzvDataGridView.SelectedRows.Count > 0)
                {
                    int reservationID = Convert.ToInt32(rzvDataGridView.SelectedRows[0].Cells["ReservationID"].Value);

                    DialogResult dialogResult = MessageBox.Show("Bu rezervasyonu silmek istediğinize emin misiniz?",
                        "Rezervasyon Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (_reservationBLL.DeleteReservationWithPayment(reservationID))
                        {
                            MessageBox.Show("Rezervasyon ve fatura başarıyla silindi!");

                            var reservationData = _reservationBLL.GetReservation();
                            rzvDataGridView.DataSource = reservationData;
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon silinemedi!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz rezervasyonu seçiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void rzvgoruntulebtn_Click(object sender, EventArgs e)
        {
            try
            {
                _reservationBLL.ReservationsAsInactive();  

                DataTable reservationData = _reservationBLL.GetReservation();
                rzvDataGridView.DataSource = reservationData;
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

        private void rzvolusturyonlendirbrn_Click(object sender, EventArgs e)
        {
            musteri_yonetimi_form musteri_Yonetimi_Form= new musteri_yonetimi_form();
            musteri_Yonetimi_Form.Show();
            this.Hide();
        }

        private void rezervasyon_islemleri_form_Load(object sender, EventArgs e)
        {
            try
            {
                _reservationBLL.ReservationsAsInactive();

                DataTable reservationData = _reservationBLL.GetReservation();
                rzvDataGridView.DataSource = reservationData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
