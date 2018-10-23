namespace QuanLy
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.BOX_PASSWORD = new System.Windows.Forms.TextBox();
            this.BOX_USER = new System.Windows.Forms.TextBox();
            this.BtnEXIT = new System.Windows.Forms.Button();
            this.BtnLOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(95, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(81, 25);
            this.LoginLabel.TabIndex = 13;
            this.LoginLabel.Text = "LOGIN";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(22, 96);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(22, 56);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(32, 13);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "User:";
            // 
            // BOX_PASSWORD
            // 
            this.BOX_PASSWORD.Location = new System.Drawing.Point(82, 93);
            this.BOX_PASSWORD.Name = "BOX_PASSWORD";
            this.BOX_PASSWORD.Size = new System.Drawing.Size(148, 20);
            this.BOX_PASSWORD.TabIndex = 8;
            this.BOX_PASSWORD.UseSystemPasswordChar = true;
            // 
            // BOX_USER
            // 
            this.BOX_USER.Location = new System.Drawing.Point(82, 53);
            this.BOX_USER.Name = "BOX_USER";
            this.BOX_USER.Size = new System.Drawing.Size(148, 20);
            this.BOX_USER.TabIndex = 7;
            // 
            // BtnEXIT
            // 
            this.BtnEXIT.Location = new System.Drawing.Point(155, 134);
            this.BtnEXIT.Name = "BtnEXIT";
            this.BtnEXIT.Size = new System.Drawing.Size(75, 23);
            this.BtnEXIT.TabIndex = 9;
            this.BtnEXIT.Text = "EXIT";
            this.BtnEXIT.UseVisualStyleBackColor = true;
            this.BtnEXIT.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // BtnLOGIN
            // 
            this.BtnLOGIN.Location = new System.Drawing.Point(36, 134);
            this.BtnLOGIN.Name = "BtnLOGIN";
            this.BtnLOGIN.Size = new System.Drawing.Size(75, 23);
            this.BtnLOGIN.TabIndex = 10;
            this.BtnLOGIN.Text = "LOGIN";
            this.BtnLOGIN.UseVisualStyleBackColor = true;
            this.BtnLOGIN.Click += new System.EventHandler(this.BtnLOGIN_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 170);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.BOX_PASSWORD);
            this.Controls.Add(this.BOX_USER);
            this.Controls.Add(this.BtnEXIT);
            this.Controls.Add(this.BtnLOGIN);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox BOX_PASSWORD;
        private System.Windows.Forms.TextBox BOX_USER;
        private System.Windows.Forms.Button BtnEXIT;
        private System.Windows.Forms.Button BtnLOGIN;
    }
}