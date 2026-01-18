using System;

namespace ConsoleApp1.Tasks;

class Test3
    
{
        static void Main(string[] args)
        {
            // 1. Declare and initialize the array
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            // 2. Ask the user for input
            Console.Write("Enter a number to search for: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Gagamit tayo ng boolean variable para ma-track kung nahanap ba ang number
            bool isFound = false;

            // 3. Use a for loop to go through the array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                // 4. Compare user input to each element
                if (numbers[i] == target)
                {
                    // If a match is found
                    Console.WriteLine($"Number found at position {i}!");
                    isFound = true; // Markahan na nahanap na ang number
                    
                    // 5. Use the break statement to stop the loop immediately
                    break; 
                }
            }

            // 6. If the loop completes and no match was found
            if (!isFound)
            {
                Console.WriteLine("Number not found in the list.");
            }
        }
}