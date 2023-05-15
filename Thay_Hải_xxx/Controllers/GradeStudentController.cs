using Microsoft.AspNetCore.Mvc;
using Thay_Hải_xxx.Entity;

namespace Thay_Hải_xxx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeStudentController: ControllerBase
    {
        public static int _id;
        public static List<studentGrade> studentGrades = new List<studentGrade>();

        [HttpPost]
        public IActionResult CreateStudentGrade(studentGrade student)
        {
            try
            {
                var result = new studentGrade()
                {
                    id = ++_id,
                    idSV = student.idSV,
                    idGrade = student.idGrade,
                };
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
