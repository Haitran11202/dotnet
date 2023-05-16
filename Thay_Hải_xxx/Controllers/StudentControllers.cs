using Microsoft.AspNetCore.Mvc;
using Thay_Hải_xxx.Dto;
using Thay_Hải_xxx.Entity;
using Thay_Hải_xxx.Services.Interfaces;

namespace Thay_Hải_xxx.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentControllers : ControllerBase
    {


        private readonly IStudentServices studentServices;

        [HttpGet]
        public IActionResult GetSinhvien()
        {
            try
            {
                var result = studentServices.GetStudent();
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public IActionResult CreateSinhVien(AddsinhvienDto input)
        {
            try
            {
                var result = studentServices.CreateSinhVien(input);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
