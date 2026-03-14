using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan1_bai2_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MSV:2415053122339
            //TenSV:Nguyễn Đăng Thắng
            //lớp:24T3

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var soLonHon5 = numbers.Where(n => n > 5);

            foreach (var n in soLonHon5)
            {
                Console.WriteLine(n);
            }
        }
    }
}
