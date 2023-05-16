using Microsoft.AspNetCore.Mvc;
using Thay_Hải_xxx.Dto;
using Thay_Hải_xxx.Entity;
using Thay_Hải_xxx.Services.Interfaces;

namespace Thay_Hải_xxx.Services.Implements
{
    public class StudentServices : IStudentServices
    {
        private readonly static List<Student> student = new List<Student>();
        private static int _id;
        public List<GetStudentDto> GetStudent()
        {
            var students = new List<GetStudentDto>();
            foreach (var st in student) { 
                var studentDto = new GetStudentDto
                {
                    Id = st.id,
                    Dob = st.Dob,
                    MaSV = st.MaSV,
                    TenSV = st.TenSV,
                };
                students.Add(studentDto);
            }
            return students;
            
        }
        public AddsinhvienDto CreateSinhVien(AddsinhvienDto input)
        {
           
            var result = new Student
            {
                id = ++_id,
                TenSV = input.TenSV,
                MaSV = input.MaSV,
                Dob = input.Dob,
            };
            student.Add(result);

            return input;
          
        }
    }
}
