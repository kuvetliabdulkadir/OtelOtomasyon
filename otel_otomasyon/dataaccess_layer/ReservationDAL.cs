using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otel_otomasyon.entity_layer;
using System.Data;
using System.Collections;
using System.Windows.Forms;



namespace otel_otomasyon.dataaccess_layer
{
    public class ReservationDAL
    {
        private myconnection _myConnection;

        public ReservationDAL()
        {
            _myConnection = new myconnection();
        }



        public DataTable GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            string query = @"SELECT r.*  FROM Rooms r WHERE r.RoomID NOT IN (SELECT DISTINCT res.RoomID FROM Reservations res WHERE (@checkIn <= res.CheckOutDate AND @checkOut >= res.CheckInDate AND res.Status != 'Cancelled')) AND r.Status = 'Available';";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@checkIn", checkInDate);
                        cmd.Parameters.AddWithValue("@checkOut", checkOutDate);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable availableRooms = new DataTable();
                            adapter.Fill(availableRooms);
                            return availableRooms;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"SQL Hatası: {ex.Message}");
                    return null;
                }
            }
        }


        public bool CreateReservation(int customerID, int roomID, DateTime checkIn, DateTime checkOut)
        {
            string query = @" INSERT INTO Reservations (CustomerID, RoomID, CheckInDate, CheckOutDate, Status) VALUES (@customerID, @roomID, @checkIn, @checkOut, 'Active')";



            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.Parameters.AddWithValue("@roomID", roomID);
                        command.Parameters.AddWithValue("@checkIn", checkIn);
                        command.Parameters.AddWithValue("@checkOut", checkOut);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }


                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon oluşturulurken hata oluştu: " + ex.Message);
                }
            }

        }



        public int GetLastReservationID()
        {
            using (MySqlCommand command = new MySqlCommand("SELECT LAST_INSERT_ID()", _myConnection.Getconnection()))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }




        public bool IsRoomAvailable(int roomID, DateTime checkIn, DateTime checkOut)
        {
            string query = @"SELECT COUNT(*) FROM Reservations WHERE RoomID = @roomID AND Status != 'Cancelled' AND (@checkIn < CheckOutDate AND @checkOut > CheckInDate)";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@roomID", roomID);
                        command.Parameters.AddWithValue("@checkIn", checkIn);
                        command.Parameters.AddWithValue("@checkOut", checkOut);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda uygunluk kontrolü sırasında hata oluştu: " + ex.Message);
                }
            }
        }



        private void UpdateRoomStatus(int roomID, string status)
        {
            string query = "UPDATE Rooms SET Status = @status WHERE RoomID = @roomID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@roomID", roomID);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda durumu güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        public bool DeletePaymentByReservationID(int reservationID)
        {
            string query = "DELETE FROM Payments WHERE ReservationID = @ReservationID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        public bool DeleteReservation(int reservationID)
        {
            string query = "DELETE FROM Reservations WHERE ReservationID = @reservationID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@reservationID", reservationID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public DataTable GetReservation()
        {
            string query = "SELECT * FROM Reservations WHERE Status != 'Cancelled'";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }

        public DataTable GetCustomerReservation(int customerID)
        {
            string query = @" SELECT  r.ReservationID, r.CheckInDate, r.CheckOutDate, p.TotalPrice, p.PaymentTime FROM Reservations r LEFT JOIN Payments p ON r.ReservationID = p.ReservationID WHERE r.CustomerID = @CustomerID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

    


        public bool UpdateReservationStatus(int reservationID, string status)
        {
            string query = "UPDATE Reservations SET Status = @status WHERE ReservationID = @reservationID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@reservationID", reservationID);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon durumu güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        public int GetLastReservationId()
        {
            string query = "SELECT MAX(ReservationID) FROM Reservations";
            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    connection.Close();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Son rezervasyon ID alınamadı.");
                    }
                }
            }
        }

        public void ReservationsAsInactive()
        {
            string query = @" UPDATE Reservations SET Status = 'Inactive' WHERE CheckOutDate < @currentDate AND Status != 'Cancelled'";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@currentDate", DateTime.Now);

                        int rowsAffected = command.ExecuteNonQuery();
                       
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Geçmiş rezervasyonlar güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

 