using System.ComponentModel.DataAnnotations;

namespace Thay_Hải_xxx.Entity
{
    public class Grade
    {
        public int id { get; set; }

        /*[Required(ErrorMessage ="ten lop k đc trống")]
        [MaxLength(50, ErrorMessage ="tối đa 50 kí tự")]*/
        public string tenLop { get; set; }
        /*[MinLength(5, ErrorMessage ="mã lớp tối thiểu là 5")]*/
        public int maLop { get; set; }
        /*[MinLength(0, ErrorMessage ="số sinh viên tối thiếu là 0")]*/
        public int maxSV { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
