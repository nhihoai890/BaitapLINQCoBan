using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Họ và tên: Phan Mai Hoài Nhi
// MSV: 22115141122112
namespace BaitapPhan1
{
    internal class Bai2
    {
        public static void ChayChuongTrinh() { 
            List<int> numbers = new List<int> { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Where(n => n > 5);
            Console.WriteLine("Bai 2: Cac so lon hon 5 trong danh sach:");
            foreach (var n in result)
            {
                Console.WriteLine(n + " ");
            }
             Console.WriteLine("\n");
        }
    }
}
