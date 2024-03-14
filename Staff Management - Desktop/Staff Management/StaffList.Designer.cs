namespace Staff_Management
{
    partial class StaffList
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
            dataGridViewStaff = new DataGridView();
            addstaffbrn = new Button();
            Exportbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStaff.BackgroundColor = SystemColors.Control;
            dataGridViewStaff.BorderStyle = BorderStyle.None;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(0, 118);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowTemplate.Height = 25;
            dataGridViewStaff.Size = new Size(1400, 732);
            dataGridViewStaff.TabIndex = 0;
            dataGridViewStaff.CellContentClick += dataGridViewStaff_CellContentClick;
            // 
            // addstaffbrn
            // 
            addstaffbrn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addstaffbrn.Location = new Point(1196, 78);
            addstaffbrn.Name = "addstaffbrn";
            addstaffbrn.Size = new Size(75, 23);
            addstaffbrn.TabIndex = 1;
            addstaffbrn.Text = "Add";
            addstaffbrn.UseVisualStyleBackColor = true;
            addstaffbrn.Click += addstaffbrn_Click;
            // 
            // Exportbutton
            // 
            Exportbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportbutton.Location = new Point(1301, 78);
            Exportbutton.Name = "Exportbutton";
            Exportbutton.Size = new Size(75, 23);
            Exportbutton.TabIndex = 2;
            Exportbutton.Text = "Export";
            Exportbutton.UseVisualStyleBackColor = true;
            Exportbutton.Click += Exportbutton_Click;
            // 
            // StaffList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1400, 850);
            Controls.Add(Exportbutton);
            Controls.Add(addstaffbrn);
            Controls.Add(dataGridViewStaff);
            Name = "StaffList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff List";
            Load += StaffList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStaff;
        private Button addstaffbrn;
        private Button Exportbutton;
    }
}