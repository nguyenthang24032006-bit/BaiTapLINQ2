using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan3_bai19_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 2, 3, 4, 4, 4, 5 };

            var mostFrequent = nums
                .GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .First().Key;

            Console.WriteLine("Số xuất hiện nhiều nhất: " + mostFrequent);
        }
    }
}
