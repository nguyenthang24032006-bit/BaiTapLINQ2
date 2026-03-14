using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan3_bai16_14_03
{
    internal class Program
    {
        static void Main(string[] args)

        //MSV:2415053122339
        //TenSV:Nguyễn Đăng Thắng
        //lớp:24T3
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            int sum = numbers.Sum();

            Console.WriteLine("Tổng = " + sum);
        }
    }
}
