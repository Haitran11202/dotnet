using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Thay_Hải_xxx.Entity;

namespace Thay_Hải_xxx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeControllers: ControllerBase
    {
        public static int _idgrade;
        public static List<Grade> grade = new List<Grade>();

        [HttpPost]
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
    }
}
