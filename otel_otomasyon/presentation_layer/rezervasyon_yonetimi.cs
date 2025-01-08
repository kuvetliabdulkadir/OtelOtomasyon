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
    public partial class rezervasyon_yonetimi : Form
    {
        private int _selectedCustomerID;
        private PaymentsBLL _paymentsBLL;
        private ReservationBLL _reservationBLL;
        public rezervasyon_yonetimi(int customerID)
        {
            InitializeComponent();

            _selectedCustomerID = customerID;
             mstridtxt.Text = customerID.ToString();
            _paymentsBLL = new PaymentsBLL();
            _reservationBLL = new ReservationBLL();

        }
       
        private void rezervasyon_yonetimi_Load(object sender, EventArgs e)
        {

        }

        private void ValidateDates()
        {
            if (checkInDatePicker.Value > checkOutDatePicker.Value)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden sonra olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkOutDatePicker.Value = checkInDatePicker.Value.AddDays(1);
            }
        }

        private void checkInDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateDates();
        }

        private void checkOutDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateDates();
        }

        private void uygunodagetirbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var checkIn = checkInDatePicker.Value;
                var checkOut = checkOutDatePicker.Value;


                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Çıkış tarihi, giriş tarihinden sonra olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable availableRooms = _reservationBLL.GetAvailableRooms(checkIn, checkOut);
                odaUygunDataGridView.DataSource = availableRooms;

                if (availableRooms.Rows.Count == 0)
                {
                    MessageBox.Show("Seçilen tarihler için uygun oda bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{availableRooms.Rows.Count} uygun oda bulundu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableRooms()
        {
            try
            {
                var checkIn = checkInDatePicker.Value;
                var checkOut = checkOutDatePicker.Value;

                DataTable availableRooms = _reservationBLL.GetAvailableRooms(checkIn, checkOut);
                odaUygunDataGridView.DataSource = availableRooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda listesini yenilerken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rzvolusturbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (odaUygunDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir oda seçiniz!");
                    return;
                }

                if (checkOutDatePicker.Value <= checkInDatePicker.Value)
                {
                    MessageBox.Show("Çıkış tarihi, giriş tarihinden sonra olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int roomID = Convert.ToInt32(odaUygunDataGridView.SelectedRows[0].Cells["RoomID"].Value);

                if (!_reservationBLL.IsRoomAvailable(roomID, checkInDatePicker.Value, checkOutDatePicker.Value))
                {
                    MessageBox.Show("Seçilen tarihlerde oda uygun değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                bool islem = _reservationBLL.CreateReservation(_selectedCustomerID,roomID,checkInDatePicker.Value,checkOutDatePicker.Value);

                if (!islem)
                {
                    MessageBox.Show("Hata: Rezervasyon yapılamadı");
                    return;
                }

                int reservationID = _reservationBLL.GetLastReservationID();

                if (reservationID <= 0)
                {
                    MessageBox.Show("Hata: Fatura oluşturulurken bir hata oluştu");
                    return;
                }

                var payment = new Payments
                {
                    CustomerID = _selectedCustomerID,
                    paymentTime = DateTime.Now,
                    totalPrice = Convert.ToDecimal(odaUygunDataGridView.SelectedRows[0].Cells["DailyPay"].Value) *
                         Math.Max((checkOutDatePicker.Value - checkInDatePicker.Value).Days, 1),
                    ReservationID = reservationID  
                };

                bool faturatslem = _paymentsBLL.AddPayment(payment);

                if (!faturatslem) 
                {
                    MessageBox.Show("Hata2: Fatura kaydedilirken hata oluştu");
                    return;
                }

                MessageBox.Show("Faturanız oluşturuldu");

                LoadAvailableRooms();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



