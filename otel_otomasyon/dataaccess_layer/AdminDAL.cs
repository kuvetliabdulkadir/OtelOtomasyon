using MySql.Data.MySqlClient;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.dataaccess_layer
{
    public class AdminDAL
    {

        private myconnection _myConnection;

        public AdminDAL()
        {
            _myConnection = new myconnection();
        }

        public Admins GetAdminUsernameAndPassword(string username, string password)
        {
            string query = "SELECT * FROM Admins WHERE Username = @username AND Password = @password";
            Admins admin = null;

            myconnection myconnection = new myconnection();
            using (var connection = myconnection.Getconnection())
            {
                try
                {
                    
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        admin = new Admins
                        {
                            AdminID = reader.GetInt32("AdminID"),
                            Name = reader.GetString("Name"),
                            Surname = reader.GetString("Surname"),
                            Username = reader.GetString("Username"),
                            Password = reader.GetString("Password")
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message);
                }
            }
            return admin;
        }


        public DataTable GetAdmins()
        {
            DataTable adminsTable = new DataTable();
            string query = "SELECT * FROM Admins";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(adminsTable);
                    }
                }
            }

            return adminsTable;
        }

        public bool DeleteAdmin(int adminID)
        {
            string query = "DELETE FROM Admins WHERE AdminID = @AdminID";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminID", adminID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; 
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Admin silme sırasında bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        public bool AddAdmin(string username, string password, string name, string surname)
        {
            
            
            string query = "INSERT INTO Admins (Username, Password, Name, Surname) VALUES (@Username, @Password, @Name, @Surname)";

            using (MySqlConnection connection = _myConnection.Getconnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Admin ekleme sırasında bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        public bool CheckUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username";
            bool exists = false;
            using (var connection = _myConnection.Getconnection())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message);
                }
            }
            return exists;
        }
    }
}
