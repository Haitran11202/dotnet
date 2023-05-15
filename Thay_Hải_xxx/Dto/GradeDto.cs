using System.ComponentModel.DataAnnotations;
using Thay_Hải_xxx.Entity;

namespace Thay_Hải_xxx.Dto
{
    public class GradeDto
    {
        [Required]
        [MinLength(1)]
        public List<Student> idSV { get; set; }

        public int idGrade { get; set; }

        
    }
}
