using ATM.Models;
using ATM.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormLogin : Form
    {
        Logic _logic = new Logic();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            OpenATM();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new FormAddUser();
            this.Hide();
            form.ShowDialog();
            if (form._closed) this.Show();
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OpenATM();
            }
        }
        private void OpenATM()
        {
            var user = _logic.GetUser(txtUser.Text, txtPass.Text);
            if (user.ID != 0)
            {
                var account = _logic.GetAccounts(user.ID);
                if (account.Count == 0)
                {
                    var result = MessageBox.Show("This user has no associated accounts, do you wish to create one?", "Account Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var newAccount = new Account { Balance = 0, UserID = user.ID, SecUserID = 0, User = user };
                        if (!_logic.AddAccount(newAccount))
                        {
                            MessageBox.Show("An error ocurred during the creation of the account, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        MessageBox.Show("Account created and linked succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        account.Add(_logic.GetAccount(user.ID));
                    }
                    else return;
                }
                if (account.Count == 1)
                {
                    var form = new FormATM(user);
                    this.Hide();
                    form.ShowDialog();
                    if (form._closed) this.Show();
                    txtPass.Text = "";
                    if (Convert.ToString(pbPasswordVisibility.Tag) == "eye_outline") ChangePasswordVisibility();
                }
                if (account.Count > 1)
                {
                    //Codigo pa cuando se tenga mas de una cuenta por usuario, hay que modificar el otro form
                    //Por "el otro form" asumo que me refiero al FormATM. Esto lo escribi dos dias despues del msj anterior y ya me olvidé
                }

            }
            else
            {
                MessageBox.Show("Incorrect user and password, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pbPasswordVisibility_Click(object sender, EventArgs e)
        {
            ChangePasswordVisibility();
        }

        private void ChangePasswordVisibility()
        {
            if (Convert.ToString(pbPasswordVisibility.Tag) == "eye_outline")
            {
                pbPasswordVisibility.Tag = "eye_outline_closed";
                pbPasswordVisibility.BackgroundImage = Resources.eye_off_outline_1024x921;
                txtPass.PasswordChar = '*';
            }
            else if (Convert.ToString(pbPasswordVisibility.Tag) == "eye_outline_closed")
            {
                pbPasswordVisibility.Tag = "eye_outline";
                pbPasswordVisibility.BackgroundImage = Resources.eye_outline_1024x718;
                txtPass.PasswordChar = '\0';
            }
        }
    }
}
