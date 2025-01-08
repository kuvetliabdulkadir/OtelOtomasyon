using otel_otomasyon.business_layer;
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
    public partial class musteri_rezervasyon_form : Form
    {
        private int _customerID;

        private ReservationBLL _reservationBLL;
        public musteri_rezervasyon_form(int customerID)
        {
            InitializeComponent();
            _customerID = customerID;
            _reservationBLL = new ReservationBLL();

        }
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            musteri_yonetimi_form musteri_Yonetimi_Form = new musteri_yonetimi_form();
            musteri_Yonetimi_Form.Show();
            this.Hide();
        }

        private void mstrzvrsilbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mstrrzvDatagridView.SelectedRows.Count > 0)
                {
                    int reservationID = Convert.ToInt32(mstrrzvDatagridView.SelectedRows[0].Cells["ReservationID"].Value);

                    DialogResult dialogResult = MessageBox.Show("Bu rezervasyonu silmek istediğinize emin misiniz?",
                        "Rezervasyon Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (_reservationBLL.DeleteReservationWithPayment(reservationID))
                        {
                            MessageBox.Show("Rezervasyon ve fatura başarıyla silindi!");

                            LoadCustomerReservations();
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

        private void LoadCustomerReservations()
        {
            try
            {
                DataTable customerReservations = _reservationBLL.GetCustomerReservations(_customerID);
                mstrrzvDatagridView.DataSource = customerReservations;

                mstrrzvDatagridView.Columns["ReservationID"].HeaderText = "ReservationID";
                mstrrzvDatagridView.Columns["CheckInDate"].HeaderText = "CheckInDate";
                mstrrzvDatagridView.Columns["CheckOutDate"].HeaderText = "CheckOutDate";
                mstrrzvDatagridView.Columns["TotalPrice"].HeaderText = "TotalPrice";
                mstrrzvDatagridView.Columns["PaymentTime"].HeaderText = "PaymentTime";

                mstrrzvDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void mstrrzvgoruntulebtn_Click(object sender, EventArgs e)
        {

            try
            {
                _reservationBLL.ReservationsAsInactive();

                DataTable reservationData = _reservationBLL.GetReservation();
                mstrrzvDatagridView.DataSource = reservationData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musteri_rezervasyon_form_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable customerReservations = _reservationBLL.GetCustomerReservations(_customerID);
                mstrrzvDatagridView.DataSource = customerReservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
