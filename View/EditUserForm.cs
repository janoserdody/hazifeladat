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

namespace View
{
    public partial class EditUserForm : Form
    {
        private BindingList<User> userList;

        private User user;

        public EditUserForm(BindingList<User> userList, User user)
        {
            this.userList = userList;

            this.user = user;

            InitializeComponent();

            InitializeForm();
        }

        private void InitializeForm()
        {
            userNameTextBox.Text = user.Username;

            passwordTextBox.Text = user.Password;

            surnameTextBox.Text = user.FamilyName;

            firstNameTextBox.Text = user.FirstName;

            dateEdit1.DateTime = user.BornDate;

            bornPlaceTextBox.Text = user.BornPlace;

            cityTextBox.Text = user.ResidenceCity;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dateEdit1.DoValidate();

            DateTime date = dateEdit1.DateTime;

            ModifyData(date);
        }

        private void ModifyData(DateTime date)
        {
            user.Username = userNameTextBox.Text;

            user.Password = passwordTextBox.Text;

            user.FamilyName = surnameTextBox.Text;

            user.FirstName = firstNameTextBox.Text;

            user.BornDate = date;

            user.BornPlace = bornPlaceTextBox.Text;

            user.ResidenceCity = cityTextBox.Text;

            try
            {
                User oldUser = userList.Where(u => u.Id == user.Id).First();

                oldUser = user;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült a módosítás!");
            }

            this.Close();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
