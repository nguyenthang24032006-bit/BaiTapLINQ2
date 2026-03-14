using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }
    public string Major { get; set; }
    public int Year { get; set; } // năm học
}

class Program
{
    static void Main()
    {
        Random rd = new Random();

        List<Student> students = new List<Student>();

        // tạo 20 sinh viên random
        for (int i = 1; i <= 20; i++)
        {
            students.Add(new Student
            {
                Id = i,
                Name = "SV" + i,
                Age = rd.Next(18, 25),
                Score = Math.Round(rd.NextDouble() * 10, 1),
                Major = (i % 2 == 0) ? "CNTT" : "QTKD",
                Year = rd.Next(1, 5)
            });
        }

        // 1. Max tuổi và Min tuổi
        int maxAge = students.Max(s => s.Age);
        int minAge = students.Min(s => s.Age);

        Console.WriteLine("Tuoi lon nhat: " + maxAge);
        Console.WriteLine("Tuoi nho nhat: " + minAge);

        // 2. Kiểm tra có SV khoa CNTT không
        bool hasIT = students.Any(s => s.Major == "CNTT");

        Console.WriteLine("Co SV khoa CNTT khong: " + hasIT);

        // 3. Lấy 10 sinh viên điểm cao nhất
        var top10 = students
            .OrderByDescending(s => s.Score)
            .Take(10);

        Console.WriteLine("\nTop 10 sinh vien diem cao:");

        foreach (var s in top10)
        {
            Console.WriteLine(s.Name + " - " + s.Score);
        }

        // 4. Bỏ qua sinh viên năm cuối (năm 4)
        var notFinalYear = students
            .Where(s => s.Year != 4);

        Console.WriteLine("\nSinh vien khong phai nam cuoi:");

        foreach (var s in notFinalYear)
        {
            Console.WriteLine(s.Name + " - Nam " + s.Year);
        }
    }
}