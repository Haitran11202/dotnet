using System.ComponentModel.DataAnnotations;

namespace Thay_Hải_xxx.Entity
{
    public class Student
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Ten la bat buoc")]
        [MaxLength(10, ErrorMessage ="tên không vượt quá 10 ký tự")]
        public string TenSV { get; set; }

        public string MaSV { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
    }
}
