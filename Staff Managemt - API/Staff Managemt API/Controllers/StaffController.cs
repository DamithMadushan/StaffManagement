using GEMBA.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SM.Application.Services.Interfaces;
using SM.Domain.DTO;
using SM.Model.Models;

namespace Staff_Managemt_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;


        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost("SaveStaffMember")]
        public bool SaveStaffMember(StaffDto staffModel)
        {
            return _staffService.SaveStaff(staffModel);
        }

        [HttpGet("GetStaffMember")]
        public StaffDto GetStaffMember(int id)
        {

            return _staffService.GetStaffByid(id);

        }



        [HttpGet("GetInitialData")]
        public InitialDto GetInitialData()
        {

            return _staffService.GetInitialData();

        }

        [HttpGet("GetStaff")]
        public List<StaffDto> GetStaff()
        {

            return _staffService.GetStaff();

        }

        
    }



}
