namespace LoginRegister
{
    partial class Registration
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCfmPass = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtUsername.Location = new System.Drawing.Point(154, 242);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(304, 36);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPassword.Location = new System.Drawing.Point(154, 309);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(304, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCfmPass
            // 
            this.txtCfmPass.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCfmPass.Location = new System.Drawing.Point(154, 376);
            this.txtCfmPass.Multiline = true;
            this.txtCfmPass.Name = "txtCfmPass";
            this.txtCfmPass.Size = new System.Drawing.Size(304, 36);
            this.txtCfmPass.TabIndex = 2;
            this.txtCfmPass.UseSystemPasswordChar = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Moccasin;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(260, 418);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 44);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Register";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Moccasin;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(473, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(149, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(149, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(149, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registration";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(27, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginRegister.Properties.Resources.UC_logofinal;
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(207, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 41);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sign Up Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(617, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCfmPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCfmPass;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}