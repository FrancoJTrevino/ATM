namespace ATM
{
    partial class FormAddUser
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
            label1 = new Label();
            btnAccept = new Button();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtDocument = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pbPasswordVisibility = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPasswordVisibility).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(12, 236);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(261, 34);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Create";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 26);
            txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 44);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 26);
            txtLastName.TabIndex = 3;
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(122, 76);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(151, 26);
            txtDocument.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 26);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(122, 140);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(151, 26);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(122, 172);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(151, 26);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(151, 26);
            txtPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 9;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 10;
            label3.Text = "Document:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 11;
            label4.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 143);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 12;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 175);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 13;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 207);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 14;
            label7.Text = "Password:";
            // 
            // pbPasswordVisibility
            // 
            pbPasswordVisibility.BackgroundImage = Properties.Resources.eye_off_outline_1024x921;
            pbPasswordVisibility.BackgroundImageLayout = ImageLayout.Zoom;
            pbPasswordVisibility.Location = new Point(90, 204);
            pbPasswordVisibility.Name = "pbPasswordVisibility";
            pbPasswordVisibility.Size = new Size(26, 26);
            pbPasswordVisibility.TabIndex = 15;
            pbPasswordVisibility.TabStop = false;
            pbPasswordVisibility.Tag = "eye_outline_closed";
            pbPasswordVisibility.Click += pbPasswordVisibility_Click;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 280);
            Controls.Add(pbPasswordVisibility);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtDocument);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(btnAccept);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "FormAddUser";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create User";
            FormClosed += FormAddUser_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbPasswordVisibility).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAccept;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtDocument;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pbPasswordVisibility;
    }
}