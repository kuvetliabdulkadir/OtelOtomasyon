using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.entity_layer
{
    public class Payments
    {
        public int paymentID;
        public int reservationID;
        public int customerID;
        public decimal totalPrice;
        public DateTime paymentTime;

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public int ReservationID { get => reservationID; set => reservationID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime PaymentTime { get => paymentTime; set => paymentTime = value; }

    }


    public class PaymentDetailsViewModel
    {
        public int PaymentID { get; set; }
        public DateTime PaymentTime { get; set; }
        public decimal TotalPrice { get; set; }

        public int ReservationID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal DailyPay { get; set; }
    }

}
