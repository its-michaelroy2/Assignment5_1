namespace Assignment5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment5_1");
            Console.WriteLine("==============\n");

            //Check for - or ) == false
            //Convert to number

            Console.WriteLine("Please enter a 3 digit number to check if it's a palindrome");
            string userInput = Console.ReadLine();

            if (userInput.StartsWith("-") || userInput.StartsWith("0") || !int.TryParse(userInput, out int number))
            {
                Console.WriteLine("Please enter a valid number. It cannot start with - or 0 since those are default non palindromic number sets.");
            }
            else
            {
                // Extract individual digits
                int firstDigit = number / 100;
                int lastDigit = number % 10;

                // Check if it's a palindrome
                if (firstDigit == lastDigit)
                {
                    Console.WriteLine($"\n{userInput} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"\n{userInput} is not a palindrome.");
                }
            }

            Console.WriteLine("\nPress enter to Continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Assignment5_2");
            Console.WriteLine("==============\n");
            Console.WriteLine("Please enter a set of numbers separated by spaces that will then be placed into an array and summed.");
            string numbers = Console.ReadLine();
            sumArrayNumbers(numbers);
        }

        public static void sumArrayNumbers(string input)
        {
            string[] numberStrings = input.Split(' ');
            int sum = 0;
            int validNumberCount = 0;

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int number))
                {
                    sum += number;
                    validNumberCount++;
                }
            }

            if (validNumberCount > 0)
            {
                Console.WriteLine($"\nThe sum of the {validNumberCount} valid numbers is: {sum}");
            }
            else
            {
                Console.WriteLine("\nNo valid numbers were entered.");
            }

            Console.WriteLine("\nPress enter to Continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Assignment5_3");
            Console.WriteLine("==============\n");
            Console.WriteLine("Please enter a set of numbers separated by spaces that will then be checked for duplicates.");
            string duplicateNum = Console.ReadLine();
            IsArrayNumsDuplicated(duplicateNum);
        }

        public static void IsArrayNumsDuplicated(string numbers)
        {
            //Input String > convert to array
            //loop through array and add to dictionary if num is duplicated
            //If duplicate num exists then +1 to number and add to dict IE: 1:3
            //If any of these property keys exist more than once output true
            //Else false

            string[] numberStrings = numbers.Split(' ');
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            bool hasDuplicates = false;

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    if (numberCounts.ContainsKey(number))
                    {
                        numberCounts[number]++;
                        hasDuplicates = true;
                    }
                    else
                    {
                        numberCounts[number] = 1;
                    }
                }
            }

            if (hasDuplicates)
            {
                Console.WriteLine();
                Console.WriteLine(hasDuplicates);
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine(hasDuplicates);
            }

        }
    }
}
