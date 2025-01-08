using MySql.Data.MySqlClient;
using otel_otomasyon.dataaccess_layer;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.business_layer
{
    public class ReservationBLL
    {

        private ReservationDAL _reservationDAL;
        private RoomBLL _roomBLL;
        private PaymentsDAL _paymentsDAL;

        public ReservationBLL()
        {
            _reservationDAL = new ReservationDAL();
            _roomBLL = new RoomBLL();
            _paymentsDAL = new PaymentsDAL();
        }

        public DataTable GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            if (checkInDate >= checkOutDate)
                throw new Exception("Çıkış tarihi giriş tarihinden sonra olmalıdır!");

            if (checkInDate.Date < DateTime.Now.Date)
                throw new Exception("Geçmiş tarihli rezervasyon yapılamaz!");

            return _reservationDAL.GetAvailableRooms(checkInDate, checkOutDate);
        }

        public bool CreateReservation(int customerID, int roomID, DateTime checkIn, DateTime checkOut)
        {
            if (customerID <= 0)
                throw new Exception("Geçerli bir müşteri seçilmelidir!");

            if (roomID <= 0)
                throw new Exception("Geçerli bir oda seçilmelidir!");


            return _reservationDAL.CreateReservation(customerID, roomID, checkIn, checkOut);
        }
        public bool IsRoomAvailable(int roomID, DateTime checkIn, DateTime checkOut)
        {
            return _reservationDAL.IsRoomAvailable(roomID, checkIn, checkOut);
        }

        public bool DeleteReservation(int reservationID)
        {
            return _reservationDAL.DeleteReservation(reservationID);
        }

        public DataTable GetReservation()
        {
            return _reservationDAL.GetReservation();
        }
        public DataTable GetCustomerReservations(int customerID)
        {
            if (customerID <= 0)
            {
                throw new ArgumentException("Geçersiz müşteri ID.");
            }

            return _reservationDAL.GetCustomerReservation(customerID);
        }

        public int GetLastReservationID()
        {
            return _reservationDAL.GetLastReservationID(); 
        }


        public bool DeleteReservationWithPayment(int reservationID)
        {
            _reservationDAL.DeletePaymentByReservationID(reservationID);

            return _reservationDAL.DeleteReservation(reservationID);
        }
        public void ReservationsAsInactive()
        {
            _reservationDAL.ReservationsAsInactive();  
        }


    }
}
