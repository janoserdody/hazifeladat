using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Model;

namespace View
{
    public partial class Main : Form
    {
        private IService service;

        private UserListForm userListForm;

        private IList<User> userList;

        public Main()
        {
            Factory factory = new Factory();

            service = factory.CreateService();

            userList = service.ReadAllDataFromDatabase();

            userListForm = new UserListForm(service, userList);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;

            string password = passwordTextBox.Text;

            bool passwordOk = false;

            User user = service.GetUserByUserName(userName);

            if (user == null)
            {
                BadPasswordMessage();
            }
            else if(password == user.Password)
            {
                passwordOk = true;

                userListForm.ShowDialog();
            }
            else
            {
                BadPasswordMessage();
            }
        }

        private static void BadPasswordMessage()
        {
            MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó!");
        }
    }
}
