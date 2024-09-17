namespace ATM
{
    partial class FormOperation
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
            lblOperation = new Label();
            txtBalance = new TextBox();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // lblOperation
            // 
            lblOperation.Location = new Point(12, 9);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(289, 19);
            lblOperation.TabIndex = 0;
            lblOperation.Text = "Introduce the amount you desire to withdrawal";
            lblOperation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(12, 31);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(289, 26);
            txtBalance.TabIndex = 1;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(116, 63);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 35);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // FormOperation
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 106);
            Controls.Add(btnAccept);
            Controls.Add(txtBalance);
            Controls.Add(lblOperation);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "FormOperation";
            Text = "Operation";
            Load += FormOperation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperation;
        private TextBox txtBalance;
        private Button btnAccept;
    }
}