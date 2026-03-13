using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Họ và tên: Phan Mai Hoài Nhi
// MSV: 22115141122112
namespace BaitapPhan1
{
    internal class Bai7
    {
        public static void ChayChuongTrinh() {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = numbers.Any(n => n > 10);
            Console.WriteLine("Bai 7: Co ton tai so lon hon 10 trong danh sach khong? " + result);
             Console.WriteLine("\n");
        }
    }
}
