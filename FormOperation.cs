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
    public partial class FormOperation : Form
    {
        string _op;
        public decimal _balance = 0;
        public FormOperation(string Operation)
        {
            InitializeComponent();
            _op = Operation;
        }

        private void FormOperation_Load(object sender, EventArgs e)
        {
            if (_op == "Deposit")
            {
                this.Text = "Deposit";
                lblOperation.Text = "Introduce the amount you desire to deposit";
            }
            else
            {
                Text = "Withdrawal";
                lblOperation.Text = "Introduce the amount you desire to withdrawal";
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _balance = Math.Round(Convert.ToDecimal(txtBalance.Text),2);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
