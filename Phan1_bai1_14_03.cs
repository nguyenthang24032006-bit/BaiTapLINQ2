using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //MSV:2415053122339
        //TenSV:Nguyễn Đăng Thắng
        //lớp:24T3
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var soChan = numbers.Where(n => n % 2 == 0);

        foreach (var n in soChan)
        {
            Console.WriteLine(n);
        }
    }
}
