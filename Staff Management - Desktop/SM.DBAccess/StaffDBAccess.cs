using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SM.DBAccess.DBModel;
using SM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;

namespace SM.DBAccess
{
    public static class StaffDBAccess
    {

        public static List<Staff> GetStaff() {


            try
            {
                List<Staff> Stafflist = new List<Staff>();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    Stafflist = db.Staff.Include(x => x.StaffType).Include(x => x.Title).Include(x => x.Status).Include(x => x.Manager).Where(x => x.StatusId == (int)EnumStatus.Active).OrderBy(x => x.FirstName).ToList();

                }

                return Stafflist;


            }
            catch(Exception ex) {

                throw ex;
            
            }
        
        
        }

        public static Staff GetStaffMember(int id)
        {

            try
            {
                Staff Staff = new Staff();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    Staff = db.Staff.Include(x => x.StaffType).Include(x => x.Title).Include(x => x.Status).Include(x => x.Manager).Where(x => x.Id == id).FirstOrDefault()!;

                }

                return Staff;


            }
            catch (Exception ex)
            {

                throw ex;

            }


        }


        public static List<Staff> GetStaffGrouped()
        {


            try
            {
                List<Staff> Stafflist = new List<Staff>();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    IEnumerable<IGrouping<int, Staff>> staffgrouped = db.Staff.Include(x => x.StaffType).Include(x => x.Title).Include(x => x.Status).Include(x => x.Manager).Where(x => x.StatusId == (int)EnumStatus.Active).OrderBy(x => x.FirstName).ToList().GroupBy(x => x.StaffTypeId).ToList();

                    IEnumerable<Staff> smths = staffgrouped.SelectMany(group => group);
                    Stafflist = smths.ToList();
                }

                return Stafflist;


            }
            catch (Exception ex)
            {

                throw ex;

            }


        }


        public static List<Title> GetTitle()
        {


            try
            {
                List<Title> title = new List<Title>();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    title = db.Titles.OrderBy(x => x.Title1).OrderBy(x => x.Id).ToList();

                }

                return title;


            }
            catch (Exception ex)
            {

                throw ex;

            }


        }


        public static List<StaffType> GetStaffType()
        {


            try
            {
                List<StaffType> staffType = new List<StaffType>();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    staffType = db.StaffTypes.OrderBy(x => x.Type).ToList();

                }

                return staffType;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }


        public static List<Status> GetStaffStatus()
        {


            try
            {
                List<Status> statues = new List<Status>();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    statues = db.Statuses.OrderBy(x => x.Status1).ToList();

                }

                return statues;

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }


        public static List<Staff> GetStaffManagers()
        {


            try
            {
                List<Staff> staffType = new List<Staff>();

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    staffType = db.Staff.Where(x => x.StaffTypeId == (int)EnumStaffTypes.Manager && x.StatusId == (int)EnumStatus.Active).OrderBy(x => x.FirstName).ToList();

                }

                return staffType;


            }
            catch (Exception ex)
            {

                throw ex;

            }


        }



        public static bool SaveStaffRecord(Staff staff)
        {


            try { 
            
                using (StaffManagementContext db = new StaffManagementContext())
                {
                    int isSaved = 0;

                    db.Staff.Add(staff);

                    isSaved =  db.SaveChanges();

                    if (isSaved != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }

               

            }
            catch (Exception ex)
            {

                throw ex;

            }


        }



        public static bool UpdateStaffRecord(Staff staff)
        {


            try
            {

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    int isSaved = 0;

                    if (db.Staff.Find(staff.Id) is Staff found)
                    {
                        db.Staff.Entry(found).State = EntityState.Detached;
                        db.Staff.Entry(staff).State = EntityState.Modified;
                        db.Staff.Entry(staff).Property(s => s.Password).IsModified = staff.Password == "" ? false : true;
                        isSaved = db.SaveChanges();
                    }



                    if (isSaved != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }



            }
            catch (Exception ex)
            {

                throw ex;

            }


        }


    }
}
