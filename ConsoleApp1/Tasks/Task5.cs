namespace ConsoleApp1.Tasks;

    class Task5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Total Students : ");
            int totalStudents = int.Parse(Console.ReadLine());

            string[,] studentData = new string[totalStudents, 5];
            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Enter Student Name : ");
                studentData[i, 0] = Console.ReadLine();

                Console.Write("Enter English Marks (Out Of 100) : ");
                int eng = int.Parse(Console.ReadLine());

                Console.Write("Enter Math Marks (Out Of 100) : ");
                int math = int.Parse(Console.ReadLine());

                Console.Write("Enter Computer Marks (Out Of 100) : ");
                int comp = int.Parse(Console.ReadLine());

                int total = eng + math + comp;
                
                studentData[i, 1] = eng.ToString();
                studentData[i, 2] = math.ToString();
                studentData[i, 3] = comp.ToString();
                studentData[i, 4] = total.ToString();

                Console.WriteLine("*********************************************");
            }

            for (int i = 0; i < totalStudents - 1; i++)
            {
                for (int j = 0; j < totalStudents - i - 1; j++)
                {
                    if (int.Parse(studentData[j, 4]) < int.Parse(studentData[j + 1, 4]))
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            string temp = studentData[j, k];
                            studentData[j, k] = studentData[j + 1, k];
                            studentData[j + 1, k] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("****************Report Card*******************");
            for (int i = 0; i < totalStudents; i++)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine($"Student Name: {studentData[i, 0]}, Position: {i + 1}, Total: {studentData[i, 4]}/300");
            }
            Console.WriteLine("****************************************");
        }
    }
