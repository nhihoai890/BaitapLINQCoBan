using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhan1
{
    // Họ và tên: Phan Mai Hoài Nhi
    // MSV: 22115141122112
    internal class Bai13
    {
        public static void ChayChuongTrinh()
        {
            List<Student> students = new List<Student>() {
                new Student() { Id = 1, Name = "An", Score = 8 },
                new Student() { Id = 2, Name = "Binh", Score = 6 },
                new Student() { Id = 3, Name = "Chi", Score = 9 },
                new Student() { Id = 4, Name = "Dung", Score = 7 },
            };
            var student = students.FirstOrDefault(s => s.Score > 7);
            if (student != null)
            {
                Console.WriteLine($"Bai13-Sinh viên đầu tiên có điểm lớn hơn 7 là: {student.Name} với điểm {student.Score}");
            }
            else
            {
                Console.WriteLine("Không có sinh viên nào có điểm lớn hơn 7.");
            }
        }
    }
}
