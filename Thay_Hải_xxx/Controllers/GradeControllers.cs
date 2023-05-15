using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Thay_Hải_xxx.Dto;
using Thay_Hải_xxx.Entity;

namespace Thay_Hải_xxx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeControllers: ControllerBase
    {
        public static int _idgrade;
        public static List<Grade> grade = new List<Grade>();

        [HttpGet("get/{id}")]
        public IActionResult GetGradeById(int id)
        {
            try
            {
                var result = grade.FirstOrDefault(s => s.id == id);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("post")]
        public IActionResult CreateGrade(Grade input)
        {
            try
            {
                var result = new Grade()
                {
                    id = ++_idgrade,
                    tenLop = input.tenLop,
                    maLop = input.maLop,
                    maxSV = input.maxSV,
                };
                grade.Add(result);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("post-sinhvien")]
        public IActionResult AddSinhVienToGrade(AddSinhViensGrade input)
        {
            try
            {
                var gradeNew = grade.FirstOrDefault(s => s.id == input.IdGrade);

                
                for (int i = 0; i < input.ListSinhViens.Count; i++)
                {
                    var addStudent = new Student
                    {
                        id = input.ListSinhViens[i].Id,
                        TenSV = input.ListSinhViens[i].TenSV,
                        Dob = input.ListSinhViens[i].Dob,
                        MaSV = input.ListSinhViens[i].MaSV,
                    };
                    gradeNew.Students.Add(addStudent);    
                }
                return Ok(gradeNew);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
