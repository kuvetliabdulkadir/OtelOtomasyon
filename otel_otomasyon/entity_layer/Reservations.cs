using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.entity_layer
{
            public class Reservations
            {
                public int reservationID;
                public int customerID;
                public int roomID;
                public DateTime checkInDate;
                public DateTime checkOutDate;
                public string status;

                public int ReservationID { get => reservationID; set => value = reservationID; }
                public int CustomerID { get => customerID; set => value = customerID; }
                public int RoomID { get => roomID; set => roomID = value; }
                public DateTime CheckInDate { get => checkInDate; set => checkInDate = value; }
                public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
                public string Status { get => status; set => status = value; }
            }
}
