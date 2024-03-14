namespace Staff_Management
{
    partial class AddStaff
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
            firstNameLabel = new Label();
            labelLastName = new Label();
            labelMiddleInitial = new Label();
            labelHomePhone = new Label();
            labelCellPhone = new Label();
            labelOfficeExtention = new Label();
            labelIRDNumber = new Label();
            labelStaffType = new Label();
            labelTitle = new Label();
            labelManager = new Label();
            labelUserName = new Label();
            label1 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMiddleInitial = new TextBox();
            textBoxHomePhone = new TextBox();
            textBoxCellPhone = new TextBox();
            textBoxOfficeExtention = new TextBox();
            textBoxIRDNumber = new TextBox();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxStaffType = new ComboBox();
            comboBoxManager = new ComboBox();
            comboBoxTitle = new ComboBox();
            comboBoxStatus = new ComboBox();
            lblStatus = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = SystemColors.ControlLightLight;
            firstNameLabel.Location = new Point(207, 140);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = SystemColors.ControlLightLight;
            labelLastName.Location = new Point(207, 192);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelMiddleInitial
            // 
            labelMiddleInitial.AutoSize = true;
            labelMiddleInitial.BackColor = SystemColors.ControlLightLight;
            labelMiddleInitial.Location = new Point(208, 245);
            labelMiddleInitial.Name = "labelMiddleInitial";
            labelMiddleInitial.Size = new Size(76, 15);
            labelMiddleInitial.TabIndex = 2;
            labelMiddleInitial.Text = "Middle Initial";
            // 
            // labelHomePhone
            // 
            labelHomePhone.AutoSize = true;
            labelHomePhone.BackColor = SystemColors.ControlLightLight;
            labelHomePhone.Location = new Point(208, 291);
            labelHomePhone.Name = "labelHomePhone";
            labelHomePhone.Size = new Size(77, 15);
            labelHomePhone.TabIndex = 3;
            labelHomePhone.Text = "Home Phone";
            // 
            // labelCellPhone
            // 
            labelCellPhone.AutoSize = true;
            labelCellPhone.BackColor = SystemColors.ControlLightLight;
            labelCellPhone.Location = new Point(208, 335);
            labelCellPhone.Name = "labelCellPhone";
            labelCellPhone.Size = new Size(64, 15);
            labelCellPhone.TabIndex = 4;
            labelCellPhone.Text = "Cell Phone";
            // 
            // labelOfficeExtention
            // 
            labelOfficeExtention.AutoSize = true;
            labelOfficeExtention.BackColor = SystemColors.ControlLightLight;
            labelOfficeExtention.Location = new Point(208, 383);
            labelOfficeExtention.Name = "labelOfficeExtention";
            labelOfficeExtention.Size = new Size(92, 15);
            labelOfficeExtention.TabIndex = 5;
            labelOfficeExtention.Text = "Office Extention";
            // 
            // labelIRDNumber
            // 
            labelIRDNumber.AutoSize = true;
            labelIRDNumber.BackColor = SystemColors.ControlLightLight;
            labelIRDNumber.Location = new Point(208, 434);
            labelIRDNumber.Name = "labelIRDNumber";
            labelIRDNumber.Size = new Size(72, 15);
            labelIRDNumber.TabIndex = 6;
            labelIRDNumber.Text = "IRD Number";
            // 
            // labelStaffType
            // 
            labelStaffType.AutoSize = true;
            labelStaffType.BackColor = SystemColors.ControlLightLight;
            labelStaffType.Location = new Point(208, 488);
            labelStaffType.Name = "labelStaffType";
            labelStaffType.Size = new Size(58, 15);
            labelStaffType.TabIndex = 7;
            labelStaffType.Text = "Staff Type";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(206, 84);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 8;
            labelTitle.Text = "Title";
            // 
            // labelManager
            // 
            labelManager.AutoSize = true;
            labelManager.BackColor = SystemColors.ControlLightLight;
            labelManager.Location = new Point(208, 548);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(54, 15);
            labelManager.TabIndex = 9;
            labelManager.Text = "Manager";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = SystemColors.ControlLightLight;
            labelUserName.Location = new Point(787, 84);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(65, 15);
            labelUserName.TabIndex = 10;
            labelUserName.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(787, 140);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "Password";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(457, 691);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(347, 691);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(341, 137);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(315, 23);
            textBoxFirstName.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(341, 189);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(315, 23);
            textBoxLastName.TabIndex = 15;
            // 
            // textBoxMiddleInitial
            // 
            textBoxMiddleInitial.Location = new Point(341, 242);
            textBoxMiddleInitial.Name = "textBoxMiddleInitial";
            textBoxMiddleInitial.Size = new Size(315, 23);
            textBoxMiddleInitial.TabIndex = 16;
            // 
            // textBoxHomePhone
            // 
            textBoxHomePhone.Location = new Point(341, 288);
            textBoxHomePhone.Name = "textBoxHomePhone";
            textBoxHomePhone.Size = new Size(315, 23);
            textBoxHomePhone.TabIndex = 17;
            // 
            // textBoxCellPhone
            // 
            textBoxCellPhone.Location = new Point(341, 332);
            textBoxCellPhone.Name = "textBoxCellPhone";
            textBoxCellPhone.Size = new Size(315, 23);
            textBoxCellPhone.TabIndex = 18;
            // 
            // textBoxOfficeExtention
            // 
            textBoxOfficeExtention.Location = new Point(341, 380);
            textBoxOfficeExtention.Name = "textBoxOfficeExtention";
            textBoxOfficeExtention.Size = new Size(315, 23);
            textBoxOfficeExtention.TabIndex = 19;
            // 
            // textBoxIRDNumber
            // 
            textBoxIRDNumber.Location = new Point(341, 431);
            textBoxIRDNumber.Name = "textBoxIRDNumber";
            textBoxIRDNumber.Size = new Size(315, 23);
            textBoxIRDNumber.TabIndex = 20;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(920, 81);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(315, 23);
            textBoxUserName.TabIndex = 23;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(920, 137);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(315, 23);
            textBoxPassword.TabIndex = 24;
            // 
            // comboBoxStaffType
            // 
            comboBoxStaffType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStaffType.FormattingEnabled = true;
            comboBoxStaffType.Location = new Point(340, 485);
            comboBoxStaffType.Name = "comboBoxStaffType";
            comboBoxStaffType.Size = new Size(316, 23);
            comboBoxStaffType.TabIndex = 25;
            comboBoxStaffType.SelectedIndexChanged += comboBoxStaffType_SelectedIndexChanged;
            // 
            // comboBoxManager
            // 
            comboBoxManager.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(340, 545);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(316, 23);
            comboBoxManager.TabIndex = 26;
            comboBoxManager.SelectedIndexChanged += comboBoxManager_SelectedIndexChanged;
            // 
            // comboBoxTitle
            // 
            comboBoxTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTitle.FormattingEnabled = true;
            comboBoxTitle.Location = new Point(340, 81);
            comboBoxTitle.Name = "comboBoxTitle";
            comboBoxTitle.Size = new Size(316, 23);
            comboBoxTitle.TabIndex = 27;
            comboBoxTitle.SelectedIndexChanged += comboBoxTitle_SelectedIndexChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(920, 192);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(316, 23);
            comboBoxStatus.TabIndex = 29;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ControlLightLight;
            lblStatus.Location = new Point(788, 195);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(268, 140);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 30;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(236, 84);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 31;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(268, 488);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 32;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(268, 192);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 33;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(829, 195);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 34;
            label6.Text = "*";
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxStatus);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxTitle);
            Controls.Add(comboBoxManager);
            Controls.Add(comboBoxStaffType);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxIRDNumber);
            Controls.Add(textBoxOfficeExtention);
            Controls.Add(textBoxCellPhone);
            Controls.Add(textBoxHomePhone);
            Controls.Add(textBoxMiddleInitial);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(labelUserName);
            Controls.Add(labelManager);
            Controls.Add(labelTitle);
            Controls.Add(labelStaffType);
            Controls.Add(labelIRDNumber);
            Controls.Add(labelOfficeExtention);
            Controls.Add(labelCellPhone);
            Controls.Add(labelHomePhone);
            Controls.Add(labelMiddleInitial);
            Controls.Add(labelLastName);
            Controls.Add(firstNameLabel);
            Name = "AddStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Staff";
            Load += AddStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label labelLastName;
        private Label labelMiddleInitial;
        private Label labelHomePhone;
        private Label labelCellPhone;
        private Label labelOfficeExtention;
        private Label labelIRDNumber;
        private Label labelStaffType;
        private Label labelTitle;
        private Label labelManager;
        private Label labelUserName;
        private Label label1;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxMiddleInitial;
        private TextBox textBoxHomePhone;
        private TextBox textBoxCellPhone;
        private TextBox textBoxOfficeExtention;
        private TextBox textBoxIRDNumber;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private ComboBox comboBoxStaffType;
        private ComboBox comboBoxManager;
        private ComboBox comboBoxTitle;
        private ComboBox comboBoxStatus;
        private Label lblStatus;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}