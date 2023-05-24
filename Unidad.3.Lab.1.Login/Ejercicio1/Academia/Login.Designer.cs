namespace Academia
{
    partial class Login
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
            lblWelcome = new Label();
            lblForgotPass = new LinkLabel();
            btnSubmitLogin = new Button();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            lblUserPass = new Label();
            btnUsername = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(122, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(179, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "¡Bienvenido al sistema!\r\nDigite su información de ingreso";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Location = new Point(23, 286);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(119, 15);
            lblForgotPass.TabIndex = 1;
            lblForgotPass.TabStop = true;
            lblForgotPass.Text = "Olvidé mi contraseña";
            lblForgotPass.LinkClicked += lblForgotPass_LinkClicked;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.BackColor = SystemColors.ButtonFace;
            btnSubmitLogin.Cursor = Cursors.Hand;
            btnSubmitLogin.Location = new Point(226, 224);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(75, 23);
            btnSubmitLogin.TabIndex = 2;
            btnSubmitLogin.Text = "Ingresar";
            btnSubmitLogin.UseVisualStyleBackColor = false;
            btnSubmitLogin.Click += btnSubmitLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(201, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(201, 165);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 4;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Location = new Point(116, 173);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(70, 15);
            lblUserPass.TabIndex = 5;
            lblUserPass.Text = "Contraseña:";
            // 
            // btnUsername
            // 
            btnUsername.AutoSize = true;
            btnUsername.Location = new Point(74, 115);
            btnUsername.Name = "btnUsername";
            btnUsername.Size = new Size(112, 15);
            btnUsername.TabIndex = 6;
            btnUsername.Text = "Nombre de usuario:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 320);
            Controls.Add(btnUsername);
            Controls.Add(lblUserPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(btnSubmitLogin);
            Controls.Add(lblForgotPass);
            Controls.Add(lblWelcome);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private LinkLabel lblForgotPass;
        private Button btnSubmitLogin;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label lblUserPass;
        private Label btnUsername;
    }
}