namespace Dictionary
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_email = new System.Windows.Forms.TextBox();
            this.login_showpass = new System.Windows.Forms.CheckBox();
            this.login_signInBtn = new System.Windows.Forms.Button();
            this.login_signUpBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Technology Lexicon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_email);
            this.panel1.Controls.Add(this.login_showpass);
            this.panel1.Controls.Add(this.login_signInBtn);
            this.panel1.Controls.Add(this.login_signUpBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(700, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 500);
            this.panel1.TabIndex = 1;
            // 
            // login_email
            // 
            this.login_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email.Location = new System.Drawing.Point(34, 145);
            this.login_email.Name = "login_email";
            this.login_email.Size = new System.Drawing.Size(351, 34);
            this.login_email.TabIndex = 9;
            this.login_email.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // login_showpass
            // 
            this.login_showpass.AutoSize = true;
            this.login_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpass.Location = new System.Drawing.Point(34, 316);
            this.login_showpass.Name = "login_showpass";
            this.login_showpass.Size = new System.Drawing.Size(149, 24);
            this.login_showpass.TabIndex = 8;
            this.login_showpass.Text = "Show password";
            this.login_showpass.UseVisualStyleBackColor = true;
            this.login_showpass.CheckedChanged += new System.EventHandler(this.login_showpass_CheckedChanged);
            // 
            // login_signInBtn
            // 
            this.login_signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signInBtn.Location = new System.Drawing.Point(34, 416);
            this.login_signInBtn.Name = "login_signInBtn";
            this.login_signInBtn.Size = new System.Drawing.Size(132, 46);
            this.login_signInBtn.TabIndex = 7;
            this.login_signInBtn.Text = "Sign in";
            this.login_signInBtn.UseVisualStyleBackColor = true;
            this.login_signInBtn.Click += new System.EventHandler(this.login_signInBtn_Click);
            // 
            // login_signUpBtn
            // 
            this.login_signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signUpBtn.Location = new System.Drawing.Point(235, 416);
            this.login_signUpBtn.Name = "login_signUpBtn";
            this.login_signUpBtn.Size = new System.Drawing.Size(132, 46);
            this.login_signUpBtn.TabIndex = 6;
            this.login_signUpBtn.Text = "Sign up";
            this.login_signUpBtn.UseVisualStyleBackColor = true;
            this.login_signUpBtn.Click += new System.EventHandler(this.login_signUpBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username/Email";
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(34, 265);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(351, 34);
            this.login_password.TabIndex = 3;
            this.login_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox login_showpass;
        private System.Windows.Forms.Button login_signInBtn;
        private System.Windows.Forms.Button login_signUpBtn;
        private System.Windows.Forms.TextBox login_email;
    }
}

