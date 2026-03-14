using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhan1
{

    // Họ và tên: Phan Mai Hoài Nhi
    // MSV: 22115141122112

    internal class Bai20
    {
        public static void ChayChuongTrinh()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7},
                new Student{Id=5, Name="Lan", Score=9.5}
            };

            var groups = students.OrderByDescending(s => s.Score).Take(3);
            Console.WriteLine("Bai20 - Top 3 Sinh vien co diem cao nhat:");
                        foreach (var student in groups)
            {
                Console.WriteLine($"{student.Name} - {student.Score}");
            }


        }
    }
}
