using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhan1
{

    // Họ và tên: Phan Mai Hoài Nhi
    // MSV: 22115141122112
    internal class Bai17
    {
        public static void ChayChuongTrinh()
        {
            List<Student> students = new List<Student>()
           {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7}
           };
            double avg = students.Average(s => s.Score);
            Console.WriteLine($" Bai17 - Điểm trung bình của lớp là: {avg}");
        }
    }
}
