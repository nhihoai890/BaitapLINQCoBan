using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Họ và tên: Phan Mai Hoài Nhi
// MSV: 22115141122112
namespace BaitapPhan1
{
    internal class Bai3
    {
        public static void ChayChuongTrinh() {

            List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

            var result = numbers.OrderBy(n => n);
            Console.WriteLine("Bai 3: Danh sach cac so duoc sap xep tang dan:");
            foreach (var n in result)
            {
                Console.WriteLine(n + " ");
            }
             Console.WriteLine("\n");

        }
          
    }
}
