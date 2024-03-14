namespace Staff_Management
{
    partial class Login
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
            password = new Label();
            userNameTextBox = new TextBox();
            passswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(199, 201);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = SystemColors.ControlLightLight;
            password.Location = new Point(199, 252);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 1;
            password.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(315, 198);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(251, 23);
            userNameTextBox.TabIndex = 2;

            // 
            // passswordTextBox
            // 
            passswordTextBox.Location = new Point(315, 249);
            passswordTextBox.Name = "passswordTextBox";
            passswordTextBox.Size = new Size(251, 23);
            passswordTextBox.TabIndex = 3;

            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(316, 308);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(119, 38);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginButton);
            Controls.Add(passswordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(password);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Management - Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label password;
        private TextBox userNameTextBox;
        private TextBox passswordTextBox;
        private Button LoginButton;
    }
}