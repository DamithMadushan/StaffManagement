using GEMBA.Domain;
using SM.Application.Repositories.Interfaces;
using SM.Application.Services.Interfaces;
using SM.Domain.DTO;
using SM.Infrastructure.Persistance.Models;
using SM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Services
{
    public class StaffService : IStaffService
    {

        private readonly IStaffRepository _staffRepository;
        public StaffService(IStaffRepository staffRepository) {
        
            _staffRepository = staffRepository;
        
        }


        /// <summary>
        /// Get staff list to gatagrid
        /// </summary>
        /// <returns></returns>
        public List<StaffDto> GetStaff()
        {
            try
            {
                List<StaffDto> staff = new List<StaffDto>();

                staff = _staffRepository.GetStaff().Select(x => new StaffDto()
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


        public StaffDto GetStaffByid(int id)
        {
            try
            {
                Staff staffMemberData = new Staff();

                staffMemberData = _staffRepository.GetStaffMember(id);

                StaffDto staffMember = new StaffDto()
                {
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
        public List<StaffDto> GetStaffToExport()
        {
            try
            {
                List<StaffDto> staff = new List<StaffDto>();

                staff = _staffRepository.GetStaffGrouped().Select(x => new StaffDto()
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
        public List<Title> GetTitle()
        {
            try
            {

                return _staffRepository.GetTitle();

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
        public List<StaffType> GetStaffType()
        {
            try
            {

                return _staffRepository.GetStaffType();

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
        public List<Status> GetStaffStatues()
        {
            try
            {

                return _staffRepository.GetStaffStatus();

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
        public List<Staff> GetStaffManagers()
        {
            try
            {
                return _staffRepository.GetStaffManagers();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        /// <summary>
        /// Get initial data
        /// </summary>
        /// <returns></returns>
        public InitialDto GetInitialData()
        {
            try
            {

                List<StaffDto> managers = new List<StaffDto>();

                //managers
                managers = _staffRepository.GetStaffManagers().Select(x => new StaffDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,

                }).ToList();


                List<TitleDto> titles = new List<TitleDto>();    


                //titles
                titles = _staffRepository.GetTitle().Select(x => new TitleDto() {
                
                    Id = x.Id,
                    Title1 = x.Title1,
                
                }).ToList();


                List<StatusDto> status = new List<StatusDto>(); 

                status = _staffRepository.GetStaffStatus().Select(x => new StatusDto() { Id = x.Id, Status1 = x.Status1}).ToList();



                //staff types
                List<StaffTypeDto> staffTypeDtos = new List<StaffTypeDto>();

                staffTypeDtos = _staffRepository.GetStaffType().Select(x => new StaffTypeDto() { Id = x.Id, Type = x.Type }).ToList();


                InitialDto initialData = new InitialDto()
                {
                    managers = managers,
                    titles = titles,
                    statuses = status,
                    staffTypes = staffTypeDtos,

                };


                return initialData;

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
        public bool SaveStaff(StaffDto staffModel)
        {
            try
            {

                Staff  staff = new Staff()
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
                    Password = staffModel.Password == "" ? staffModel.Password : Hash(staffModel.Password!),
                    ManagerId = staffModel.ManagerId,
                    StatusId = staffModel.StatusId,
                };


                if (_staffRepository.SaveStaffRecord(staff))
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
        public bool UpdateStaff(StaffDto staffModel)
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
                    Password = staffModel.Password == "" ? staffModel.Password : Hash(staffModel.Password!),
                    ManagerId = staffModel.ManagerId,
                    StatusId = staffModel.StatusId,
                };


                if (_staffRepository.UpdateStaffRecord(staff))
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


        public static string Hash(string passwordToHash)
        {
            try
            {
                using (SHA1 sha1Hash = SHA1.Create())
                {
                    //From String to byte array
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordToHash);
                    byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                    return hash;
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
