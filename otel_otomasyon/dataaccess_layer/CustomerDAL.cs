using MySql.Data.MySqlClient;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.dataaccess_layer
{
    public class CustomerDAL
    {
        private myconnection _myConnection;

        public CustomerDAL()
        {
           _myConnection = new myconnection();
        }


        public bool  AddCustomer(string name, string surname, string email, string phoneNumber)
        {
            string query = "INSERT INTO Customers (Name, Surname, Email, PhoneNumber) VALUES (@name, @surname, @email, @phoneNumber)";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        public DataTable GetCustomer()
        {
            string query = "SELECT * FROM Customers";

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

        public bool DeleteCustomer(int customerID)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri silinirken bir hata oluştu: " + ex.Message);
                }
            }


        }
        public bool UpdateCustomer(Customers customer)
        {
            string query = "UPDATE Customers SET Name = @Name, Surname = @Surname, PhoneNumber = @PhoneNumber, Email = @Email WHERE CustomerID = @CustomerID";

            using (var connection = _myConnection.Getconnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Surname", customer.Surname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public Customers GetCustomerDetails(int customerID)
        {
            string query = "SELECT CustomerID, Name, Surname, PhoneNumber, Email FROM Customers WHERE CustomerID = @CustomerID";

            using (var cmd = new MySqlCommand(query, _myConnection.Getconnection()))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customers
                        {
                            CustomerID = reader.GetInt32("CustomerID"),
                            Name = reader.GetString("Name"),
                            Surname = reader.GetString("Surname"),
                            PhoneNumber = reader.GetString("PhoneNumber"),
                            Email = reader.GetString("Email")
                        };
                    }
                }
            }

            return null; 
        }
    }
}
