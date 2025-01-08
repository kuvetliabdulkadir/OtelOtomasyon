using MySql.Data.MySqlClient;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon.dataaccess_layer
{
    public class RoomDAL
    {
        private myconnection _myConnection;

        public RoomDAL()
        {
            _myConnection = new myconnection();
        }

        public bool AddRoom( int roomNumber, string roomType, decimal dailyPay, string status)
        {
            string query = "INSERT INTO Rooms (RoomNumber, RoomType, DailyPay, Status) VALUES (@roomNumber, @roomType, @dailyPay, @status)";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@roomNumber", roomNumber);
                    command.Parameters.AddWithValue("@roomType", roomType);
                    command.Parameters.AddWithValue("@dailyPay", dailyPay);
                    command.Parameters.AddWithValue("@status", status);

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        public DataTable GetRooms( )
        {
            string query = "SELECT * FROM Rooms";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        public bool DeleteRoom(int roomID)
        {
            string query = "DELETE FROM Rooms WHERE RoomID = @RoomID"; 

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomID", roomID); 

                        int rowsAffected = command.ExecuteNonQuery(); 

                        return rowsAffected > 0; 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda silinirken bir hata oluştu: " + ex.Message);
                }
            }


        }

        public bool UpdateRoomStatus(int roomID, string status)
        {
            string query = "UPDATE Rooms SET Status = @Status WHERE RoomID = @RoomID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status); 
                        command.Parameters.AddWithValue("@RoomID", roomID); 

                        int rowsAffected = command.ExecuteNonQuery(); 

                        return rowsAffected > 0; 
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda durumu güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        public bool UpdateRoom(Rooms room)
        {
            string query = @" UPDATE Rooms SET RoomNumber = @RoomNumber, RoomType = @RoomType, DailyPay = @DailyPay, Status = @Status WHERE RoomID = @RoomID";

            using (var connection = _myConnection.Getconnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomID", room.RoomID); 
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@DailyPay", room.DailyPay);
                    cmd.Parameters.AddWithValue("@Status", room.Status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

            public bool IsRoomNumberExists(int roomNumber, int roomID)
            {
                string query = @"SELECT COUNT(*) FROM Rooms WHERE RoomNumber = @RoomNumber AND RoomID != @RoomID";

                using (var connection = _myConnection.Getconnection())
                {
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; 
                    }
                }
            }


        public Rooms GetRoomDetails(int roomID)
        {
            string query = "SELECT RoomID, RoomNumber, RoomType, DailyPay,Status FROM Rooms WHERE RoomID = @RoomID";

            using (var cmd = new MySqlCommand(query, _myConnection.Getconnection()))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Rooms
                        {
                            RoomID = reader.GetInt32("RoomID"),
                            RoomNumber = reader.GetInt32("RoomNumber"),
                            RoomType = reader.GetString("RoomType"),
                            DailyPay = reader.GetDecimal("DailyPay"),
                            Status = reader.GetString("Status")
                        };
                    }
                }
            }

            return null;
        }
    }
}
