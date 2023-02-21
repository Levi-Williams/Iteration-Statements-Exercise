namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        
        //Write a method that will print to the console all numbers 1000 through - 1000
        
        public static void PrintAllNumbers() 
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }   
       
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintNumbersByThree()
        {
            for (int i = 3; i < 1000; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void CheckTwoNumbersEqual(int x, int y)
        {
            if(x == y)
            {
                Console.WriteLine("These numbers are equal");
            }
            else { Console.WriteLine("These numbers are NOT equal");
            }
        }
        
        //Write a method to check whether a given number is even or odd

        public static void CheckIfNumberIsEvenOrOdd(int x)  //Could also create shorter method by using bool true or false and choosing to select even or odd. It can only be one of two//
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative

        public static void CheckIfNumberIsPositive(int x)
        {
            if(x >= 0)
            {
                Console.WriteLine("This number is positive");
            }
            else
            {
                Console.WriteLine("This number is negative");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanYouVote()
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You cannot vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IsNumberWithinRange(int x)
        {
            if(x >= -10 && x <= 10)
            {
                Console.WriteLine("This number is within the range of -10 and 10!");
            }
            else
            {
                Console.WriteLine("This number is not within range of 10 and -10");
            }
        }
        
        //OR OPTION 2

        public static void IsNumberWithinUserRange()
        {
            Console.WriteLine("Please pick a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine("This number is within the range of -10 and 10!");
            }
            else
            {
                Console.WriteLine("This number is not within range of 10 and -10");
            }

        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void DisplayMultiplicationTable(int x)
        {
            for(int number = 1; number <= 12; number++)
            {
                var multiplcationTable = x * number;
                Console.WriteLine(multiplcationTable);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintAllNumbers();

            PrintNumbersByThree();

            CheckTwoNumbersEqual(12, 248);

            CheckIfNumberIsEvenOrOdd(35);

            CheckIfNumberIsPositive(-203);

            CanYouVote();

            IsNumberWithinRange(11);

            IsNumberWithinUserRange();

            DisplayMultiplicationTable(18);


        }
    }
}
