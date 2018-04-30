using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeEnd;

namespace UserLogin
{
    public partial class LoginForm : Form
    {
        string username;
        string password;

        protected static EmployeeForm m_EmployeeInfo = new EmployeeForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            username = TextboxUsername.Text;
            password = TextboxPassword.Text;

            //Send Details to server to be validated here

            //Placeholder "login". Use the returned values from the php lookup to compare and match the details here.
            //User a for loop for as many entrys until it matches or ends
            if(username == "Admin"
                && password == "Password")
            {
                m_EmployeeInfo.ShowDialog();
            }
            else
                MessageBox.Show("The login does not exist. Please check the Username and Password are correct.", "Login Error", MessageBoxButtons.OK);

            //Use this else statement as a check after the for loop if the login was unsuccessful
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
