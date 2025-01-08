using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.entity_layer
{
    public class Rooms
    {
        public int roomID;
        public int roomNumber;
        public string roomType;
        public decimal dailyPay;
        public string status;

        public int RoomID { get => roomID; set => roomID = value; }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public decimal DailyPay { get => dailyPay; set => dailyPay = value; }
        public string Status { get => status; set => status = value; }

    }
}
