using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Họ và tên: Phan Mai Hoài Nhi
// MSV: 22115141122112
namespace BaitapPhan1
{
    internal class Bai18
    {
        public static void ChayChuongTrinh()
        {
            List<Student> students = new List<Student> {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=5}
            };

            var groups = students.GroupBy(s =>
            {
                if (s.Score >= 8)
                {
                    return "Gioi";
                }
                else if (s.Score >= 6)
                {
                    return "Kha";
                }
                else 
                {
                    return "Trung Binh";
                }
            });
            foreach (var g in groups) {
                Console.WriteLine("Xep loai " + g.Key);
                foreach (var item in g)
                {
                    Console.WriteLine(item.Name + " - " + item.Score);
                }
                Console.WriteLine();
            }

        }
    }
}
