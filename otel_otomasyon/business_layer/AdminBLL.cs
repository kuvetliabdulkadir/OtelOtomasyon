using otel_otomasyon.dataaccess_layer;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace otel_otomasyon.business_layer
{
    public class AdminBLL
    {

        private AdminDAL _adminDAL;
        public AdminBLL()
        {
            _adminDAL = new AdminDAL();
        }

        public bool oturumdogrula(string username, string password)
        {
            Admins admin = _adminDAL.GetAdminUsernameAndPassword(username, password);

            if (admin != null)
            {
                
                return true;
            }
            return false;
        }

        public DataTable GetAdmins()
        {
            return _adminDAL.GetAdmins();
        }

        public bool DeleteAdmin(int adminID)
        {
            if (adminID <= 0)
            {
                throw new Exception("Geçersiz Admin ID.");
            }

            return _adminDAL.DeleteAdmin(adminID);
        }

        public bool AddAdmin(string username, string password, string name, string surname)
        {
            if (username == "Kullanıcı Adı" || password == "Parolanız" || name == "Adınız" || surname == "Soyadınız" || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen tüm alanları doğru bir şekilde doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (IsUsernameExist(username))
            {
                throw new Exception("Bu kullanıcı adı zaten mevcut.");
            }
            if (!IsValidPassword(password))
            {
                throw new Exception("Şifreniz en az 6 karakter uzunluğunda olmalı ve en az bir büyük harf içermelidir.");
            }
            return _adminDAL.AddAdmin(username, password, name, surname);




        }
        private bool IsUsernameExist(string username)
        {
            return _adminDAL.CheckUsernameExist(username);
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 6 && password.Any(char.IsUpper);
        }
    }
}
