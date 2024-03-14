using MaterialSkin.Controls;
using SM.BusinessLogic.Services;
using SM.DBAccess.DBModel;
using SM.Model.Enums;
using SM.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Staff_Management
{
    public partial class AddStaff : MaterialForm
    {

        int staffID = 0; //Staff id to determine add/edit mode

        public AddStaff(int id)
        {
            InitializeComponent();
            staffID = id;
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            try
            {

                List<Title> titles = StaffService.GetTitle();
                titles.Insert(0, new Title() { Id = -1, Title1 = "--select--" });
                comboBoxTitle.DataSource = titles;
                comboBoxStaffType.SelectedItem = -1;
                comboBoxStaffType.SelectedText = "--select--";
                comboBoxTitle.DisplayMember = "Title1"; ;
                comboBoxTitle.ValueMember = "Id"; ;


                List<StaffType> staffTypes = StaffService.GetStaffType();
                staffTypes.Insert(0, new StaffType() { Id = -1, Type = "--select--" });
                comboBoxStaffType.DataSource = staffTypes;
                comboBoxStaffType.SelectedItem = -1;
                comboBoxStaffType.SelectedText = "--select--";
                comboBoxStaffType.DisplayMember = "Type"; ;
                comboBoxStaffType.ValueMember = "Id";


                List<Staff> staff = StaffService.GetStaffManagers();
                staff.Insert(0, new Staff() { Id = -1, FirstName = "--select--" });
                comboBoxManager.DataSource = staff;
                comboBoxManager.SelectedItem = -1;
                comboBoxManager.SelectedText = "--select--";
                comboBoxManager.DisplayMember = "Firstname"; ;
                comboBoxManager.ValueMember = "Id";


                List<SM.DBAccess.DBModel.Status> statues = StaffService.GetStaffStatues();
                statues.Insert(0, new SM.DBAccess.DBModel.Status() { Id = -1, Status1 = "--select--" });
                comboBoxStatus.DataSource = statues;
                comboBoxStatus.SelectedItem = -1;
                comboBoxStatus.SelectedText = "--select--";
                comboBoxStatus.DisplayMember = "Status1"; ;
                comboBoxStatus.ValueMember = "Id";

                if (staffID == 0)
                {
                    //hide manager dropdown
                    labelManager.Visible = false;
                    comboBoxManager.Visible = false;
                    this.Text = "Add staff details";
                    buttonSave.Text = "Save";
                }
                else
                {

                    this.Text = "Edit staff details";
                    buttonSave.Text = "Update";

                    StaffModel staffMember = StaffService.GetStaffByid(staffID);

                    if (staffMember != null)
                    {
                        comboBoxTitle.SelectedIndex = staffMember.TitleId == 0 ? -1 : staffMember.TitleId;
                        textBoxFirstName.Text = staffMember.FirstName;
                        textBoxLastName.Text = staffMember.LastName;
                        textBoxMiddleInitial.Text = staffMember.MiddleInitial;
                        textBoxHomePhone.Text = staffMember.HomePhone;
                        textBoxCellPhone.Text = staffMember.CellPhone;
                        textBoxOfficeExtention.Text = staffMember.OfficeExtention;
                        textBoxIRDNumber.Text = staffMember.Irdnumber;
                        comboBoxStaffType.SelectedIndex = staffMember.StaffTypeId == 0 ? -1 : staffMember.StaffTypeId;
                        textBoxUserName.Text = staffMember.Username;
                        comboBoxManager.SelectedIndex = staffMember.ManagerId! == null ? -1 : (int)staffMember.ManagerId!;
                        comboBoxStatus.SelectedIndex = staffMember.StatusId == 0 ? -1 : staffMember.StatusId;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occoured while loading data!", "Error!");

                var staff = new StaffList();
                staff.Show();

                this.Hide();

            }


        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show manager if staff type employee
            if (comboBoxStaffType.SelectedIndex == (int)EnumStaffTypes.Employee)
            {
                labelManager.Visible = true;
                comboBoxManager.Visible = true;
            }
            else
            {
                labelManager.Visible = false;
                comboBoxManager.Visible = false;
                comboBoxManager.SelectedItem = -1;
                comboBoxManager.SelectedText = "--select--";
            }
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var staff = new StaffList();
            staff.Show();

            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //check required fields
                if (comboBoxTitle.SelectedIndex <= 0 || string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) || comboBoxStaffType.SelectedIndex <= 0 || comboBoxStatus.SelectedIndex <= 0)
                {

                    MessageBox.Show("Please fill all required fields!", "Info");

                }
                else
                {

                    StaffModel staff = new StaffModel()
                    {
                        Id = staffID,
                        TitleId = comboBoxTitle.SelectedIndex,
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        MiddleInitial = textBoxMiddleInitial.Text,
                        HomePhone = textBoxHomePhone.Text,
                        CellPhone = textBoxCellPhone.Text,
                        OfficeExtention = textBoxOfficeExtention.Text,
                        Irdnumber = textBoxIRDNumber.Text,
                        StaffTypeId = comboBoxStaffType.SelectedIndex,
                        Username = textBoxUserName.Text,
                        Password = textBoxPassword.Text,
                        ManagerId = comboBoxManager.SelectedIndex,
                        StatusId = comboBoxStatus.SelectedIndex,
                    };

                    if(staffID == 0 )
                    {
                        if (StaffService.SaveStaff(staff))
                        {
                            MessageBox.Show("Data saved successfully!", "Success");

                            var stafflist = new StaffList();
                            stafflist.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Data not saved!", "Error");
                        }
                    }
                    else
                    {
                        if (StaffService.UpdateStaff(staff))
                        {
                            MessageBox.Show("Data updated successfully!", "Success");

                            var stafflist = new StaffList();
                            stafflist.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Data not updated!", "Error");
                        }
                    }



                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occoured while saving data", "Error");
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
