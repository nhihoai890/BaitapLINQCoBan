using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhan1
{

    // Họ và tên: Phan Mai Hoài Nhi
    // MSV: 22115141122112
    internal class Bai15
    {
        public static void ChayChuongTrinh()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var result = numbers.Distinct();
            Console.WriteLine("Bai15 - Danh sach sach so loai bo sau khi trung: ");
            foreach (var number in result)
            {
                Console.WriteLine( number + "");
            }
            Console.WriteLine();
        }
    }
}
