using System;

namespace Part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher()
            {
                IdentityNumber = "Id001",
                Name = "Nguyen Tien",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchool = "HS001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            var universityTeacher = new UniversityTeacher()
            {
                IdentityNumber = "Id002",
                Name = "Tien Nguyen ",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 9000,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "HS001"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}