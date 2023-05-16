using Thay_Hải_xxx.Dto;

namespace Thay_Hải_xxx.Services.Interfaces
{
    public interface IStudentServices
    {
        AddsinhvienDto CreateSinhVien(AddsinhvienDto input);
        List<GetStudentDto> GetStudent();
    }
}
