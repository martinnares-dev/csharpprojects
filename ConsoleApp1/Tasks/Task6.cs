namespace ConsoleApp1.Tasks;

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }

        public bool IsPassed()
        {
            return Grade >= 75;
        }
    }

    class Task6
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.Name = "Martin";
            student1.Age = 20;
            student1.Grade = 85.5;

            student1.DisplayInfo();
            
            string status = student1.IsPassed() ? "Passed" : "Failed";
            Console.WriteLine($"Status: {status}");
        }
    }
