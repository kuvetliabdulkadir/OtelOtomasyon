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
    public partial class fatura_yonetimi_form : Form
    {
        private PaymentsBLL _paymentsBLL;
        private PaymentsDAL _paymentsDAL;
        public fatura_yonetimi_form()
        {
            InitializeComponent();
            _paymentsDAL = new PaymentsDAL();
            _paymentsBLL = new PaymentsBLL();
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void faturalistelebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            yonetici_islemleri_form yonetici_İslemleri_Form = new yonetici_islemleri_form();
            yonetici_İslemleri_Form.Show();
            this.Hide();
        }

     


        private void fatura_yonetimi_form_Load(object sender, EventArgs e)
        {
            try
            {
                var paymentsData = _paymentsBLL.GetPayment();
                faturaDataGrifView.DataSource = paymentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void ShowPaymentDetails(int paymentID)
        {
            var paymentDetails = _paymentsBLL.GetPaymentDetails(paymentID);

            if (paymentDetails == null)
            {
                MessageBox.Show("Fatura detayları bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkInDate = paymentDetails.CheckInDate.ToString("yyyy-MM-dd");
            string checkOutDate = paymentDetails.CheckOutDate.ToString("yyyy-MM-dd");
            string paymentTime = paymentDetails.PaymentTime.ToString("yyyy-MM-dd");


            string details = $"Fatura ID: {paymentDetails.PaymentID}\n" +
                              $"Fatura Tarihi: {paymentTime}\n" +
                             $"Toplam Fiyat: {paymentDetails.TotalPrice:C}\n\n" +
                             $"Rezervasyon ID: {paymentDetails.ReservationID}\n" +
                             $"Giriş Tarihi: {checkInDate}\n" +
                             $"Çıkış Tarihi: {checkOutDate}\n\n" +
                             $"Müşteri ID: {paymentDetails.CustomerID}\n" +
                             $"Müşteri Adı: {paymentDetails.Name}\n" +
                             $"Müşteri Soyadı: {paymentDetails.Surname}\n"+
                             $"E-posta : {paymentDetails.Email}\n"+
                             $"Telefon: {paymentDetails.PhoneNumber}\n\n" +
                             $"Oda ID: {paymentDetails.RoomID}\n" +
                             $"Oda Numarası: {paymentDetails.RoomNumber}\n" +
                             $"Oda Tipi: {paymentDetails.RoomType}\n" +
                             $"Günlük Oda Ücreti: {paymentDetails.DailyPay:C}";

            MessageBox.Show(details, "Fatura Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void faturaDataGrifView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int paymentID = Convert.ToInt32(faturaDataGrifView.Rows[e.RowIndex].Cells["PaymentID"].Value);

                ShowPaymentDetails(paymentID);
            }
        }
    }
}
