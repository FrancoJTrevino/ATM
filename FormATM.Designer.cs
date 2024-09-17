namespace ATM
{
    partial class FormATM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lnkLogout = new LinkLabel();
            btnWithdrawal = new Button();
            lblAccNum = new Label();
            lblBalance = new Label();
            btnDeposit = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(13, 9);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(217, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username: GenericUsername1234";
            // 
            // lnkLogout
            // 
            lnkLogout.AutoSize = true;
            lnkLogout.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkLogout.Location = new Point(251, 9);
            lnkLogout.Margin = new Padding(4, 0, 4, 0);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(60, 19);
            lnkLogout.TabIndex = 1;
            lnkLogout.TabStop = true;
            lnkLogout.Text = "Log Out";
            lnkLogout.LinkClicked += lnkLogout_LinkClicked;
            // 
            // btnWithdrawal
            // 
            btnWithdrawal.Location = new Point(13, 151);
            btnWithdrawal.Margin = new Padding(4);
            btnWithdrawal.Name = "btnWithdrawal";
            btnWithdrawal.Size = new Size(106, 35);
            btnWithdrawal.TabIndex = 2;
            btnWithdrawal.Text = "Withdrawal";
            btnWithdrawal.UseVisualStyleBackColor = true;
            btnWithdrawal.Click += btnWithdrawal_Click;
            // 
            // lblAccNum
            // 
            lblAccNum.AutoSize = true;
            lblAccNum.Location = new Point(13, 45);
            lblAccNum.Margin = new Padding(4, 0, 4, 0);
            lblAccNum.Name = "lblAccNum";
            lblAccNum.Size = new Size(168, 19);
            lblAccNum.TabIndex = 3;
            lblAccNum.Text = "Account Nº: 1234567890";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(13, 82);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(136, 19);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "Balance: $99999999";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(207, 151);
            btnDeposit.Margin = new Padding(4);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(106, 35);
            btnDeposit.TabIndex = 5;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // FormATM
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 199);
            Controls.Add(btnDeposit);
            Controls.Add(lblBalance);
            Controls.Add(lblAccNum);
            Controls.Add(btnWithdrawal);
            Controls.Add(lnkLogout);
            Controls.Add(lblUsername);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormATM";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            FormClosed += FormATM_FormClosed;
            Load += FormATM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private LinkLabel lnkLogout;
        private Button btnWithdrawal;
        private Label lblAccNum;
        private Label lblBalance;
        private Button btnDeposit;
    }
}
