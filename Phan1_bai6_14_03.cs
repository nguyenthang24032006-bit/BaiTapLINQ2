using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan1_bai6_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MSV:2415053122339
            //TenSV:Nguyễn Đăng Thắng
            //lớp:24T3
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            int soLuongChan = numbers.Count(n => n % 2 == 0);

            Console.WriteLine("Số lượng số chẵn: " + soLuongChan);
        }
    }
}
