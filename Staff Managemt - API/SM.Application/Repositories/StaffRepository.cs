using Microsoft.EntityFrameworkCore;
using SM.Application.Repositories.Interfaces;
using SM.Infrastructure.Persistance.Models;
using SM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Repositories
{
    public class StaffRepository : BaseRepository,IStaffRepository
    {
        public StaffRepository(StaffManagementDBContext db) : base(db)
        { 
        

        }


        public List<Staff> GetStaff()
        {


            try
            {
                List<Staff> Stafflist = new List<Staff>();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
                {
                    Stafflist = db.Staff.Include(x => x.StaffType).Include(x => x.Title).Include(x => x.Status).Include(x => x.Manager).Where(x => x.StatusId == (int)EnumStatus.Active).OrderBy(x => x.FirstName).ToList();

                }

                return Stafflist;


            }
            catch (Exception ex)
            {

                throw ex;

            }


        }

        public  Staff GetStaffMember(int id)
        {

            try
            {
                Staff Staff = new Staff();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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


        public  List<Staff> GetStaffGrouped()
        {


            try
            {
                List<Staff> Stafflist = new List<Staff>();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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


        public  List<Title> GetTitle()
        {


            try
            {
                List<Title> title = new List<Title>();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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


        public  List<StaffType> GetStaffType()
        {


            try
            {
                List<StaffType> staffType = new List<StaffType>();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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


        public  List<Status> GetStaffStatus()
        {


            try
            {
                List<Status> statues = new List<Status>();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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


        public  List<Staff> GetStaffManagers()
        {


            try
            {
                List<Staff> staffType = new List<Staff>();

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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



        public bool SaveStaffRecord(Staff staff)
        {


            try
            {

                using (StaffManagementDBContext db = new StaffManagementDBContext())
                {
                    int isSaved = 0;

                    db.Staff.Add(staff);

                    isSaved = db.SaveChanges();

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



        public bool UpdateStaffRecord(Staff staff)
        {


            try
            {

                using (StaffManagementDBContext db = new StaffManagementDBContext())
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
