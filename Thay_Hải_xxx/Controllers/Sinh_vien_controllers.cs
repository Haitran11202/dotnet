using Microsoft.AspNetCore.Mvc;
using Thay_Hải_xxx.Dto;
using Thay_Hải_xxx.Entity;

namespace Thay_Hải_xxx.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Sinh_vien_controllers : ControllerBase
    {
        public static List<Student> student = new List<Student>();
        public static int _id;

        public static List<Grade> grades = new List<Grade>();

        [HttpGet]
        public IActionResult GetSinhvien()
        {
            try
            {
                var result = student.ToList();
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
                var result = new Student
                {
                    id = ++_id,
                    TenSV = input.TenSV,
                    MaSV = input.MaSV,
                    Dob = input.Dob,
                };
                student.Add(result);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
