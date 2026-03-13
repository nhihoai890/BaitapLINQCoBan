using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhan1
{
    // Họ và tên: Phan Mai Hoài Nhi
    // MSV: 22115141122112
    internal class Bai14
    {
        public static void ChayChuongTrinh()
        {
            List<Student> students = new List<Student>() {
                new Student() { Id = 1, Name = "An", Score = 8 },
                new Student() { Id = 2, Name = "Binh", Score = 6 },
                new Student() { Id = 3, Name = "Chi", Score = 9 },
                new Student() { Id = 4, Name = "Dung", Score = 7 },
            };
            bool result = students.Any(s => s.Score < 5);
            Console.WriteLine("Bai14 - Co sinh vien rot khong?" + result);
        }
    }
}
