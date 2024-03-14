using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin.Controls;
using SM.BusinessLogic.Services;
using SM.DBAccess.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XAct.Messages;

namespace Staff_Management
{
    public partial class StaffList : MaterialForm
    {
        private int currentPage = 0;

        public StaffList()
        {
            InitializeComponent();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {

            try
            {
                //Load data to data grid
                dataGridViewStaff.DataSource = StaffService.GetStaff();

                dataGridViewStaff.Columns[0].Visible = false;
                dataGridViewStaff.Columns[1].Visible = false;
                dataGridViewStaff.Columns[2].Visible = false;
                dataGridViewStaff.Columns[10].Visible = false;
                dataGridViewStaff.Columns[11].Visible = false;
                dataGridViewStaff.Columns[13].Visible = false;
                dataGridViewStaff.Columns[18].Visible = false;
                dataGridViewStaff.Columns[19].Visible = false;
                dataGridViewStaff.Columns[20].Visible = false;
                dataGridViewStaff.Columns[21].Visible = false;



                DataGridViewButtonColumn buttonColEdit = new DataGridViewButtonColumn();
                buttonColEdit.Name = "Edit";
                buttonColEdit.Text = "Edit";
                buttonColEdit.UseColumnTextForButtonValue = true;

                dataGridViewStaff.Columns.Add(buttonColEdit);




            }
            catch (Exception ex)
            {


                MessageBox.Show("An error occoured while loading data - " + ex.Message, "Error");

            }

        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStaff[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                DataGridViewRow selectedRow = dataGridViewStaff.Rows[e.RowIndex];
                int id = (int)selectedRow.Cells["Id"].Value;

                var staff = new AddStaff(id);
                staff.Show();

                this.Close();

            }
        }

        private void maximiseButton_Click(object sender, EventArgs e)
        {

            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            //maximises window
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }

        private void Exportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog;
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                DialogResult dr = saveFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = saveFileDialog.FileName;


                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        writer.WriteLine("Title,FirstName,LastName,MiddleInitial,StaffType,HomePhone,CellPhone,OfficeExtention,Irdnumber,Manager,Status");

                        // Write each staff record
                        foreach (var staff in StaffService.GetStaffToExport())
                        {
                            writer.WriteLine($"{staff.Title},{staff.FirstName},{staff.LastName},{staff.MiddleInitial},{staff.StaffType},{staff.HomePhone},{staff.CellPhone},{staff.OfficeExtention},{staff.Irdnumber},{staff.Manager},{staff.Status}");
                        }
                    }


                    MessageBox.Show("File successfully saved!", "Success");


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Staff export failed - " + ex.Message, "Error");

            }
        }

        private void addstaffbrn_Click(object sender, EventArgs e)
        {
            var staff = new AddStaff(0);
            staff.Show();

            this.Close();
        }

    



    }
}
