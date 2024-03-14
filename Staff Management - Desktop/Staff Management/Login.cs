using MaterialSkin.Controls;
using SM.BusinessLogic.Services;
using SM.DBAccess.DBModel;
using SM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XAct.Messages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Staff_Management
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            passswordTextBox.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            login();

        }



        private void login()
        {

            try
            {

                LoginModel loginModel = new LoginModel();

                loginModel.UserName = userNameTextBox.Text;
                loginModel.Password = passswordTextBox.Text;


                bool isLoggingSuccess = LoginService.LoginEmployee(loginModel);

                if (isLoggingSuccess)
                {
                    var staff = new StaffList();
                    staff.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login not successful!", "Message");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occoured during login - " + ex.Message, "Error");
            }



        }

    
    }
}
