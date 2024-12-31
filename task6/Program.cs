namespace task6

{

    // Enum for days of the week
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    // Enum for seasons
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    // Enum for permissions
    enum Permissions
    {
        Read ,
        Write ,
        Delete,
        Execute
    }

    // Enum for colors
    enum Colors
    {
        Red,
        Green,
        Blue,
    }

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
            #region Sum of Digits 
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The sum is: {SumOfDigits(number)}");
            #endregion

            #region IsPrime
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(number));
            #endregion

            #region MinMaxArray 
            //int[] array = { 10, 20, 5, 8, 30, 3 };
            //MinMaxArray(array, out int min, out int max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            #endregion

            #region Factorial Example
            //Console.Write("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Factorial is {Factorial(number)}");
            #endregion

            #region Sum and Subtraction Example
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //SumAndSubtract(num1, num2, out int sum, out int difference);
            //Console.WriteLine($"Sum: {sum}, Difference: {difference}");
            #endregion

            #region Change Character in String Example
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();
            //Console.Write("Enter position to modify (0-based): ");
            //int position = int.Parse(Console.ReadLine());
            //Console.Write("Enter new character: ");
            //char newChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //Console.WriteLine($"Modified string: {ChangeChar(inputString, position, newChar)}");
            #endregion

            # region Print all days of the week
            Console.WriteLine("Days of the Week:");
            foreach (var day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region  Display season's month range
            Console.WriteLine("Enter a season:");
            string seasonInput = Console.ReadLine();
            if (Enum.TryParse(seasonInput, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            #endregion

            #region
            #endregion
            #region  Check primary colors
            Console.WriteLine("\nEnter a color:");
            string colorInput = Console.ReadLine();
            if (Enum.TryParse(colorInput, true, out Colors color))
            {
                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{color} is a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{color} is not a primary color.");
                        break;
                }
            }
         
            #endregion

        }
    }
}



