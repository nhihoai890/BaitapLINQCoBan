using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhan1
{


    // Họ và tên: Phan Mai Hoài Nhi
    // MSV: 22115141122112
    internal class Bai11
    {
        public static void ChayChuongTrinh() {
            List<Student> students = new List<Student>() { 
                new Student() { Id = 1, Name = "An", Score = 8 },
                new Student() { Id = 2, Name = "Binh", Score = 6 },
                new Student() { Id = 3, Name = "Chi", Score = 9 },
                new Student() { Id = 4, Name = "Dung", Score = 7 },
            };
            var result = students.OrderByDescending(s => s.Score).First();
            Console.WriteLine("Bai - 11 Sinh vien diem cao nhat:");
            Console.WriteLine($"Id: {result.Id}, Name: {result.Name}, Score: {result.Score}");

        }
    }
}
