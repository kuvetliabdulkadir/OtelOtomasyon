using MySql.Data.MySqlClient;
using otel_otomasyon.entity_layer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyon.dataaccess_layer
{
    public class PaymentsDAL

    {
        private myconnection _myConnection;

        public PaymentsDAL()
        {
            _myConnection = new myconnection();
        }

        public bool AddPayment(Payments payments)
        {
            string query = "INSERT INTO Payments (ReservationID, CustomerID, TotalPrice, PaymentTime) VALUES (@ReservationID, @CustomerID, @TotalPrice, NOW())";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", payments.reservationID);
                    command.Parameters.AddWithValue("@CustomerID", payments.customerID);
                    command.Parameters.AddWithValue("@TotalPrice", payments.totalPrice);
                    command.Parameters.AddWithValue("NOW", payments.paymentTime);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetPayment()
        {
            string query = "SELECT * FROM Payments";

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


        public bool DeletePaymentByReservationID(int reservationID)
        {
            string query = "DELETE FROM Payments WHERE ReservationID = @reservationID";

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


        public PaymentDetailsViewModel GetPaymentDetails(int paymentID)
        {
            string query = @"SELECT p.PaymentID, p.PaymentTime, p.TotalPrice, r.ReservationID, DATE(r.CheckInDate) AS CheckInDate, DATE(r.CheckOutDate) AS CheckOutDate,
            c.CustomerID, c.Name, c.Surname, c.PhoneNumber, c.Email,
            ro.RoomID, ro.RoomNumber, ro.RoomType, ro.DailyPay FROM Payments p JOIN Reservations r ON p.ReservationID = r.ReservationID JOIN Customers c ON r.CustomerID = c.CustomerID
            JOIN Rooms ro ON r.RoomID = ro.RoomID WHERE p.PaymentID = @PaymentID";

            using (var connection = _myConnection.Getconnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PaymentDetailsViewModel
                            {
                                PaymentID = reader.GetInt32("PaymentID"),
                                PaymentTime = reader.GetDateTime("PaymentTime"),
                                TotalPrice = reader.GetDecimal("TotalPrice"),
                                ReservationID = reader.GetInt32("ReservationID"),
                                CheckInDate = reader.GetDateTime("CheckInDate"),
                                CheckOutDate = reader.GetDateTime("CheckOutDate"),
                                CustomerID = reader.GetInt32("CustomerID"),
                                Name = reader.GetString("Name"),
                                Surname = reader.GetString("Surname"),
                                PhoneNumber = reader.GetString("PhoneNumber"),
                                Email = reader.GetString("Email"),
                                RoomID = reader.GetInt32("RoomID"),
                                RoomNumber = reader.GetInt32("RoomNumber"),
                                RoomType = reader.GetString("RoomType"),
                                DailyPay = reader.GetDecimal("DailyPay")

                            };
                        }
                    }
                }
            }

            return null; 
        }
    }
}
