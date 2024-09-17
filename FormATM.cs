using ATM.Models;

namespace ATM
{
    public partial class FormATM : Form
    {
        Logic _logic = new Logic();
        User _user;
        Account _account;
        public bool _closed = false;
        public FormATM(User user)
        {
            InitializeComponent();
            _user = user;
            _account = _logic.GetAccount(_user.ID);
        }

        void ChangeBalance(decimal balance, string operation)
        {
            switch (operation)
            {
                case "Deposit":
                    _account.Balance += balance;
                    break;
                case "Withdrawal":
                    if (_account.Balance - balance < 0)
                    {
                        MessageBox.Show("Withdrawing that ammount would let your balance in the negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        _account.Balance -= balance;
                    break;
            }
            if (!_logic.UpdateAccount(_account))
            {
                MessageBox.Show("An error ocurred during the transaction, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _account = _logic.GetAccount(_user.ID);
            }
            lblBalance.Text = "Balance: $" + _account.Balance.ToString();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            var operationForm = new FormOperation("Withdrawal");
            var result = operationForm.ShowDialog();
            if (result == DialogResult.OK)
                ChangeBalance(operationForm._balance, "Withdrawal");

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var operationForm = new FormOperation("Deposit");
            var result = operationForm.ShowDialog();
            if (result == DialogResult.OK)
                ChangeBalance(operationForm._balance, "Deposit");
        }

        private void FormATM_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Username: " + _user.Username;
            lblAccNum.Text = "Account Nº: " + _account.ID;
            lblBalance.Text = "Balance: $" + _account.Balance;
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _closed = true;
            Close();
        }

        private void FormATM_FormClosed(object sender, FormClosedEventArgs e)
        {
            _closed = true;
        }
    }
}
