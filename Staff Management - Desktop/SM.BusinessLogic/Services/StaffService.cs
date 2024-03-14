using SM.DBAccess;
using SM.DBAccess.DBModel;
using SM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BusinessLogic.Services
{
    public static class StaffService
    {

        /// <summary>
        /// Get staff list to gatagrid
        /// </summary>
        /// <returns></returns>
        public static List<StaffModel> GetStaff()
        {
            try
            {
                List<StaffModel> staff = new List<StaffModel>();

                staff = StaffDBAccess.GetStaff().Select(x => new StaffModel()
                {
                    Id = x.Id,
                    Title = x.Title.Title1,
                    FirstName = x.FirstName,
                    MiddleInitial = x.MiddleInitial,
                    LastName = x.LastName,
                    StaffType = x.StaffType.Type,
                    HomePhone = x.HomePhone,
                    CellPhone = x.CellPhone,
                    OfficeExtention = x.OfficeExtention,
                    Irdnumber = x.Irdnumber,                   
                    Manager = x!.Manager == null ? "" : x!.Manager!.FirstName!,
                    Username = x.Username,
                    Status = x.Status.Status1,

                }).ToList();


                return staff;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static StaffModel GetStaffByid(int id)
        {
            try
            {
                Staff staffMemberData = new Staff();

                staffMemberData = StaffDBAccess.GetStaffMember(id);

                StaffModel staffMember = new StaffModel() {
                    Id = staffMemberData.Id,
                    Title = staffMemberData.Title.Title1,
                    TitleId = staffMemberData.TitleId,
                    FirstName = staffMemberData.FirstName,
                    MiddleInitial = staffMemberData.MiddleInitial,
                    LastName = staffMemberData.LastName,
                    StaffType = staffMemberData.StaffType.Type,
                    HomePhone = staffMemberData.HomePhone,
                    CellPhone = staffMemberData.CellPhone,
                    OfficeExtention = staffMemberData.OfficeExtention,
                    Irdnumber = staffMemberData.Irdnumber,
                    Manager = staffMemberData!.Manager == null ? "" : staffMemberData!.Manager!.FirstName!,
                    Username = staffMemberData.Username,
                    Status = staffMemberData.Status.Status1,
                    ManagerId = staffMemberData.ManagerId,
                    StaffTypeId = staffMemberData.StaffTypeId,
                    StatusId = staffMemberData.StatusId,

                };


                return staffMember;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Get staff list to export
        /// </summary>
        /// <returns></returns>
        public static List<StaffModel> GetStaffToExport()
        {
            try
            {
                List<StaffModel> staff = new List<StaffModel>();

                staff = StaffDBAccess.GetStaffGrouped().Select(x => new StaffModel()
                {
                    Title = x.Title.Title1,
                    FirstName = x.FirstName,
                    MiddleInitial = x.MiddleInitial,
                    LastName = x.LastName,
                    StaffType = x.StaffType.Type,
                    HomePhone = x.HomePhone,
                    CellPhone = x.CellPhone,
                    OfficeExtention = x.OfficeExtention,
                    Irdnumber = x.Irdnumber,
                    Manager = x!.Manager == null ? "" : x!.Manager!.FirstName!,
                    Status = x.Status.Status1,
                

                }).ToList();


                return staff;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /// <summary>
        /// Get titles
        /// </summary>
        /// <returns></returns>
        public static List<Title> GetTitle()
        {
            try
            {

                return StaffDBAccess.GetTitle();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /// <summary>
        /// Get staff types
        /// </summary>
        /// <returns></returns>
        public static List<StaffType> GetStaffType()
        {
            try
            {

                return StaffDBAccess.GetStaffType();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        /// <summary>
        /// Get Statues
        /// </summary>
        /// <returns></returns>
        public static List<Status> GetStaffStatues()
        {
            try
            {

                return StaffDBAccess.GetStaffStatus();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        /// <summary>
        /// Get staff manager list
        /// </summary>
        /// <returns></returns>
        public static List<Staff> GetStaffManagers()
        {
            try
            {
                return StaffDBAccess.GetStaffManagers();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        /// <summary>
        /// Save staff record
        /// </summary>
        /// <param name="staffModel"></param>
        /// <returns></returns>
        public static bool SaveStaff(StaffModel staffModel)
        {
            try
            {

                Staff staff = new Staff()
                {
                    TitleId = staffModel.TitleId,
                    FirstName = staffModel.FirstName!,
                    LastName = staffModel.LastName!,
                    MiddleInitial = staffModel.MiddleInitial,
                    HomePhone = staffModel.HomePhone,
                    CellPhone = staffModel.CellPhone!,
                    OfficeExtention = staffModel.OfficeExtention,
                    Irdnumber = staffModel.Irdnumber,
                    StaffTypeId = staffModel.StaffTypeId,
                    Username = staffModel.Username,
                    Password = staffModel.Password == "" ? staffModel.Password : LoginService.Hash(staffModel.Password!),
                    ManagerId = staffModel.ManagerId,
                    StatusId = staffModel.StatusId,
                };


                if (StaffDBAccess.SaveStaffRecord(staff))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }


        /// <summary>
        /// Update staff record
        /// </summary>
        /// <param name="staffModel"></param>
        /// <returns></returns>
        public static bool UpdateStaff(StaffModel staffModel)
        {
            try
            {

                Staff staff = new Staff()
                {
                    Id = staffModel.Id,
                    TitleId = staffModel.TitleId,
                    FirstName = staffModel.FirstName!,
                    LastName = staffModel.LastName!,
                    MiddleInitial = staffModel.MiddleInitial,
                    HomePhone = staffModel.HomePhone,
                    CellPhone = staffModel.CellPhone!,
                    OfficeExtention = staffModel.OfficeExtention,
                    Irdnumber = staffModel.Irdnumber,
                    StaffTypeId = staffModel.StaffTypeId,
                    Username = staffModel.Username,
                    Password = staffModel.Password == "" ? staffModel.Password : LoginService.Hash(staffModel.Password!),
                    ManagerId = staffModel.ManagerId,
                    StatusId = staffModel.StatusId,
                };


                if (StaffDBAccess.UpdateStaffRecord(staff))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
