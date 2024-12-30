namespace task6

{
     class Program
    {
        #region q1 Sum of Digits Function
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region IsPrime Function
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region MinMaxArray Function
        static void MinMaxArray(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];

            foreach (int num in array)
            {
                if (num < min) 
                    min = num;
                if (num > max) 
                    max = num;
            }
        }
        #endregion

        #region Iterative Factorial Function
        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region Sum and Subtraction Function
        static void SumAndSubtract(int a, int b, out int sum, out int difference)
        {
            sum = a + b;
            difference = a - b;
        }
        #endregion

        #region Change Character in String Function
        static string ChangeChar(string input, int position, char newChar)
        {
            char[] charArray = input.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray);
        }
        #endregion

        static void Main()
        {
            #region Sum of Digits Example
            Console.Write("Enter a number for Sum of Digits: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of the number {number} is: {SumOfDigits(number)}");
            #endregion

            #region IsPrime Example
            Console.Write("Enter a number to check if it's prime: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number) ? $"{number} is a prime number." : $"{number} is not a prime number.");
            #endregion

            #region MinMaxArray Example
            int[] array = { 10, 20, 5, 8, 30, 3 };
            MinMaxArray(array, out int min, out int max);
            Console.WriteLine($"Array: {string.Join(", ", array)}");
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            #endregion

            #region Factorial Example
            Console.Write("Enter a number to calculate its factorial: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
            #endregion

            #region Sum and Subtraction Example
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            SumAndSubtract(num1, num2, out int sum, out int difference);
            Console.WriteLine($"Sum: {sum}, Difference: {difference}");
            #endregion

            #region Change Character in String Example
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.Write("Enter position to modify (0-based): ");
            int position = int.Parse(Console.ReadLine());
            Console.Write("Enter new character: ");
            char newChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"Modified string: {ChangeChar(inputString, position, newChar)}");
            #endregion
        }
    }
}



