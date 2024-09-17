namespace ATM
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            txtPass = new TextBox();
            btnLogIn = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            btnAddUser = new Button();
            pbPasswordVisibility = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPasswordVisibility).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "User:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(124, 42);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(140, 26);
            txtPass.TabIndex = 2;
            txtPass.KeyPress += CheckEnterKeyPress;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(12, 83);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(252, 33);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(124, 6);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(140, 26);
            txtUser.TabIndex = 1;
            txtUser.KeyPress += CheckEnterKeyPress;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(11, 122);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(253, 33);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Create New User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // pbPasswordVisibility
            // 
            pbPasswordVisibility.BackgroundImage = Properties.Resources.eye_off_outline_1024x921;
            pbPasswordVisibility.BackgroundImageLayout = ImageLayout.Zoom;
            pbPasswordVisibility.Location = new Point(92, 42);
            pbPasswordVisibility.Name = "pbPasswordVisibility";
            pbPasswordVisibility.Size = new Size(26, 26);
            pbPasswordVisibility.TabIndex = 16;
            pbPasswordVisibility.TabStop = false;
            pbPasswordVisibility.Tag = "eye_outline_closed";
            pbPasswordVisibility.Click += pbPasswordVisibility_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 165);
            Controls.Add(pbPasswordVisibility);
            Controls.Add(btnAddUser);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Controls.Add(txtPass);
            Controls.Add(lblUser);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "FormLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbPasswordVisibility).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtPass;
        private Button btnLogIn;
        private Label label1;
        private TextBox txtUser;
        private Button btnAddUser;
        private PictureBox pbPasswordVisibility;
    }
}