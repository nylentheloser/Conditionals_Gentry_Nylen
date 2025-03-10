namespace Conditionals_Gentry_Nylen
{
    internal class Program
    {
        static void CheckNumber(int num)
        {
            string result = num + " is ";

            if (num > 0)
            {
                result += "positive and ";
            }
            else if (num < 0)
            {
                result += "negative and ";
            }
            else
            {
                result += "zero and ";
            }

            if (num % 2 == 0)
            {
                result += "even.";
            }
            else
            {
                result += "odd.";
            }

            Console.WriteLine(result);
        }

        // Function to print the grade description based on the given grade
        static void GradeDescription(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Superior");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("Below Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }

        static void Main(string[] args)
        {
            // Assign a whole number to check
            int number1 = 4 ;
            CheckNumber(number1); // Example number

            // Assign two more numbers
            int number2 = -7;
            int number3 = 15;

            // Comparing the numbers to find the largest
            int largestNumber = Math.Max(Math.Max(number1, number2), number3);
            Console.WriteLine($"The largest number is: {largestNumber}");

            // Test the grade description function
            GradeDescription('B'); // Example grade
        }
    }
}