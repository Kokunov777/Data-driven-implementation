using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private AuthenticationService _authenticationService;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;

        public Form2()
        {
            _authenticationService = new AuthenticationService();
            InitializeForm();
        }

      

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (_authenticationService.AuthenticateUser(username, password))
            {
                AuthenticationService.UserRole role = _authenticationService.GetUserRole(username);
                Form1 mainForm = new Form1(role, username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
