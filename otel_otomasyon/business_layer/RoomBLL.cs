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
    public class RoomBLL
    {
        private RoomDAL _roomDAL;

        public RoomBLL()
        {
            _roomDAL = new RoomDAL();
        }

        public bool AddRoom(int roomNumber, string roomType, decimal dailyPay, string status)
        {
            return _roomDAL.AddRoom(roomNumber, roomType, dailyPay, status);
        }

        public DataTable GetRooms()
        {
            return _roomDAL.GetRooms(); 
        }

        public bool DeleteRoom(int roomID)
        {
            return _roomDAL.DeleteRoom(roomID); 
        }

        public bool UpdateRoomStatus(int roomID, string status)
        {
            return _roomDAL.UpdateRoomStatus(roomID, status); 
        }

        public bool IsRoomNumberExists(int roomNumber, int roomID)
        {
            return _roomDAL.IsRoomNumberExists(roomNumber, roomID);
        }

        public bool UpdateRoom(Rooms room)
        {
            return _roomDAL.UpdateRoom(room);
        }
        public Rooms GetRoomDetails(int roomID)
        {
            return _roomDAL.GetRoomDetails(roomID); 
        }

    }
}
