
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Phan2_bai10_14_03
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MSV:2415053122339
            //TenSV:Nguyễn Đăng Thắng
            //lớp:24T3
            List<Student> students = new List<Student>()
            {
                new Student{Id=1, Name="An", Score=8},
                new Student{Id=2, Name="Binh", Score=6},
                new Student{Id=3, Name="Chi", Score=9},
                new Student{Id=4, Name="Dung", Score=7}
            };
            var diemGiamDan = students.OrderByDescending(s => s.Score);

            foreach (var s in diemGiamDan)
            {
                Console.WriteLine(s.Name + " - " + s.Score);
            }
        }
    }
}