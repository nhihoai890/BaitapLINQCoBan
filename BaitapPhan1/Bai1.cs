using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Họ và tên: Phan Mai Hoài Nhi
// MSV: 22115141122112
namespace BaitapPhan1
{
    internal class Bai1
    {
        public static void ChayChuongTrinh() { 
            List<int> numbers = new List<int> { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Bai 1: Cac so chan trong danh sach:");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n + " ");

            }
            Console.WriteLine("\n");
        }

    }
}
