using System;
namespace Activity4
{
    abstract class Student
    {
        protected string? name;
        protected double grade; 
        public void SetData(string name, double grade) 
        {
            this.name = name;
            this.grade = grade;
        }
        public abstract void DisplayInfo();
        public abstract int CheckStatus();
    }
    class CollegeStudent : Student
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"College Student Name: {name}, Grade: {grade}");
        Console.WriteLine($"Status: {(CheckStatus() == 1 ? "Passed" : "Failed")}");
    }
    public override int CheckStatus()
    {
        return (grade >= 1.00 && grade <= 3.00) ? 1 : 0;
    }
}
    class SeniorStudent : Student
    {
        private double passingGrade = 75; 
        public override void DisplayInfo()
        {
            Console.WriteLine($"Senior Student Name: {name}, Grade: {grade}");
            Console.WriteLine($"Status: {(CheckStatus() == 1 ? "Passed" : "Failed")}");
        }
        public override int CheckStatus()
        {
            return grade >= passingGrade ? 1 : 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student collegeStudent1 = new CollegeStudent();
            collegeStudent1.SetData("Ado", 4.00);
            collegeStudent1.DisplayInfo();

            Student collegeStudent2 = new CollegeStudent();
            collegeStudent2.SetData("Johnny Sins", 1.00);
            collegeStudent2.DisplayInfo();

            Student seniorStudent1 = new SeniorStudent();
            seniorStudent1.SetData("Matthew Nunez", 80);
            seniorStudent1.DisplayInfo();

            Student seniorStudent2 = new SeniorStudent();
            seniorStudent2.SetData("Skibidi Rizz Sigma Ohio", 98);
            seniorStudent2.DisplayInfo();
        }
    }
}