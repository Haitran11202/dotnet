using System.ComponentModel.DataAnnotations;

namespace Thay_Hải_xxx.Entity
{
    public class studentGrade
    {
        public int id { get; set; }
        [Required]
        [MinLength(1)]
        public int idSV { get; set; }

        public int idGrade { get; set; }
    }
}
