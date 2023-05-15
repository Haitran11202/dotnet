using System.ComponentModel.DataAnnotations;

namespace Thay_Hải_xxx.Entity
{
    public class studentGrade
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        public int IdSV { get; set; }

        public int IdGrade { get; set; }
    }
}
