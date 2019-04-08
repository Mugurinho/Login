namespace Login
{
    partial class GenerateLogin
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUniqueGeneratedKeyInsert = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGeneratedKeyInsert = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtGeneratedKeyDisplay = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblGeneratedKeyDisplay = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEmailKey = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(121, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "email*";
            // 
            // lblUniqueGeneratedKeyInsert
            // 
            this.lblUniqueGeneratedKeyInsert.AutoSize = true;
            this.lblUniqueGeneratedKeyInsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueGeneratedKeyInsert.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUniqueGeneratedKeyInsert.Location = new System.Drawing.Point(53, 235);
            this.lblUniqueGeneratedKeyInsert.Name = "lblUniqueGeneratedKeyInsert";
            this.lblUniqueGeneratedKeyInsert.Size = new System.Drawing.Size(112, 16);
            this.lblUniqueGeneratedKeyInsert.TabIndex = 1;
            this.lblUniqueGeneratedKeyInsert.Text = "insert unique key*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtGeneratedKeyInsert
            // 
            this.txtGeneratedKeyInsert.Location = new System.Drawing.Point(171, 234);
            this.txtGeneratedKeyInsert.Name = "txtGeneratedKeyInsert";
            this.txtGeneratedKeyInsert.Size = new System.Drawing.Size(233, 20);
            this.txtGeneratedKeyInsert.TabIndex = 3;
            this.txtGeneratedKeyInsert.TextChanged += new System.EventHandler(this.txtGenerator_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Location = new System.Drawing.Point(171, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtGeneratedKeyDisplay
            // 
            this.txtGeneratedKeyDisplay.Location = new System.Drawing.Point(171, 260);
            this.txtGeneratedKeyDisplay.Name = "txtGeneratedKeyDisplay";
            this.txtGeneratedKeyDisplay.Size = new System.Drawing.Size(233, 20);
            this.txtGeneratedKeyDisplay.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(168, 324);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 6;
            // 
            // lblGeneratedKeyDisplay
            // 
            this.lblGeneratedKeyDisplay.AutoSize = true;
            this.lblGeneratedKeyDisplay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedKeyDisplay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGeneratedKeyDisplay.Location = new System.Drawing.Point(49, 261);
            this.lblGeneratedKeyDisplay.Name = "lblGeneratedKeyDisplay";
            this.lblGeneratedKeyDisplay.Size = new System.Drawing.Size(116, 16);
            this.lblGeneratedKeyDisplay.TabIndex = 7;
            this.lblGeneratedKeyDisplay.Text = "display unique key";
            this.lblGeneratedKeyDisplay.Click += new System.EventHandler(this.lblGeneratedKeyDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Location = new System.Drawing.Point(419, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEmailKey
            // 
            this.btnEmailKey.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailKey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEmailKey.Location = new System.Drawing.Point(278, 286);
            this.btnEmailKey.Name = "btnEmailKey";
            this.btnEmailKey.Size = new System.Drawing.Size(126, 29);
            this.btnEmailKey.TabIndex = 9;
            this.btnEmailKey.Text = "generate email key";
            this.btnEmailKey.UseVisualStyleBackColor = true;
            this.btnEmailKey.Click += new System.EventHandler(this.btnEmailKey_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Location = new System.Drawing.Point(419, 429);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 24);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(155, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 80);
            this.label3.TabIndex = 11;
            this.label3.Text = "USER LOGIN WITH UNIQUE KEY\r\n\r\n*Please provide your email \r\n\r\n*Insert the unique g" +
    "enerated key via email\r\n";
            // 
            // GenerateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEmailKey);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGeneratedKeyDisplay);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtGeneratedKeyDisplay);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtGeneratedKeyInsert);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUniqueGeneratedKeyInsert);
            this.Controls.Add(this.lblEmail);
            this.Name = "GenerateLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate unique key";
            this.Load += new System.EventHandler(this.GenerateLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUniqueGeneratedKeyInsert;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGeneratedKeyInsert;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtGeneratedKeyDisplay;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblGeneratedKeyDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmailKey;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
    }
}