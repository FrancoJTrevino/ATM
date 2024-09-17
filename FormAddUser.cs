using ATM.Models;
using ATM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class FormAddUser : Form
    {
        Logic _logic = new Logic();
        public bool _closed = false;
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!CheckTXT()) return;
            var user = new User { Name = txtName.Text, LastName = txtLastName.Text, Document = txtDocument.Text, Email = txtEmail.Text, PhoneNumber = txtPhoneNumber.Text, Username = txtUsername.Text };
            user.Password = _logic.Hash(txtPassword.Text);
            if (!_logic.AddUser(user))
            {
                MessageBox.Show("An error ocurred during the creation of the user, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("User created correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var result = MessageBox.Show("Do you wish to create and link an account to this user now?", "Account Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var user2 = _logic.GetUser(user.ID);
                    var account = new Account { Balance = 0, UserID = user2.ID, SecUserID = 0, User = user2 };
                    if (!_logic.AddAccount(account))
                    {
                        MessageBox.Show("An error ocurred during the creation of the account, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Account created and linked correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }

        }
        private void FormAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _closed = true;
        }

        private void pbPasswordVisibility_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(pbPasswordVisibility.Tag) == "eye_outline")
            {
                pbPasswordVisibility.Tag = "eye_outline_closed";
                pbPasswordVisibility.BackgroundImage = Resources.eye_off_outline_1024x921;
                txtPassword.PasswordChar = '*';
            }
            else if (Convert.ToString(pbPasswordVisibility.Tag) == "eye_outline_closed")
            {
                pbPasswordVisibility.Tag = "eye_outline";
                pbPasswordVisibility.BackgroundImage = Resources.eye_outline_1024x718;
                txtPassword.PasswordChar = '\0';
            }
        }

        private bool CheckTXT()
        {
            if (txtName.Text == "" || txtName.Text.Length > 100)
            {
                MessageBox.Show("Name must not be empty and must not surpass 100 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLastName.Text == "" || txtLastName.Text.Length > 100)
            {
                MessageBox.Show("Last name must not be empty and must not surpass 100 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDocument.Text == "" || txtDocument.Text.Length > 10)
            {
                MessageBox.Show("Document must not be empty and must not surpass 10 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "" || txtEmail.Text.Length > 100)
            {
                MessageBox.Show("Email must not be empty and must not surpass 100 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Must be a valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPhoneNumber.Text == "" || txtPhoneNumber.Text.Length > 20)
            {
                MessageBox.Show("Phone Number must not be empty and must not surpass 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtUsername.Text == "" || txtUsername.Text.Length > 25)
            {
                MessageBox.Show("Username must not be empty and must not surpass 25 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_logic.UserExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists, please introduce another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text == "" || txtPassword.Text.Length > 16)
            {
                MessageBox.Show("Password must not be empty and must not surpass 16 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
