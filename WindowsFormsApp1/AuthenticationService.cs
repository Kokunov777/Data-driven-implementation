using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AuthenticationService 
    {
        // метод читает из App.config
        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                var credentials = ConfigurationManager.AppSettings
                    .AllKeys
                    .ToDictionary(k => k, v => ConfigurationManager.AppSettings[v]);

                foreach (var cred in credentials)
                {
                    string[] parts = cred.Value.Split(':');
                    if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения конфигурации: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public UserRole GetUserRole(string username)
        {
            switch (username.ToLower())
            {
                case "admin": return UserRole.Administrator;
                case "root": return UserRole.Manager;
                case "employee": return UserRole.Employee;
                default: return UserRole.Guest;
            }
        }

        public enum UserRole
        {
            Administrator,
            Manager,
            Employee,
            Guest
        }
    }
}
