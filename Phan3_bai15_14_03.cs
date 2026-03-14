using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan3_bai15_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var uniqueNumbers = numbers.Distinct();

            foreach (var n in uniqueNumbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
