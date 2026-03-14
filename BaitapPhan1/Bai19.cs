using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Họ và tên: Phan Mai Hoài Nhi
// MSV: 22115141122112
namespace BaitapPhan1
{
    internal class Bai19
    {
        public static void ChayChuongTrinh()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4 };
            var result = numbers.GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .First();

            Console.WriteLine("Bai19 -  So xuat hien nhieu nhat: " + result.Key);
        }
    }
}
