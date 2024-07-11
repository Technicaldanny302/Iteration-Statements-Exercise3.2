using System.Globalization;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange(int cieling, int floor)
        {
            for (int i = cieling; i >= floor; i--)
                Console.WriteLine(i);
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3) ;
            Console.WriteLine("k");
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CounterTwo(int a, int b)
        {

            var check = (a == b) ? true : false;

            return check;

        }
        //Write a method to check whether a given number is even or odd
        public static bool isPositive(int a)
        {
            Console.WriteLine("pick a number");
            Console.ReadLine();
            if (a <= 0)
            {
                Console.WriteLine($"Your number{a} is even");
                return true;
            }
            Console.WriteLine("Your number is odd");
            return false;
        }



        //Write a method to check whether a given number is positive or negative
        public static bool posNumber(int a)
        {
            Console.WriteLine($"pick a number");
            Console.ReadLine();
            if (a >= 0)
            {
                Console.WriteLine("Your balnce is positive");
                return true;
            }
            Console.WriteLine("your balance is negative");
            return false;
            
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool TryVote(int age)
        {
            if ( age >= 18 ) 
            {
                return true;
            }
                return false;
        }
            
    

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool numRange(int a)
        {
            if (a >= -10 && a <= 10)
            {
                return true;
            }
                return false;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int givenNumber)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (var number in numbers)
            {
                Console.WriteLine(givenNumber * number);  
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintRange(1000,-1000);
            Threes();
            CounterTwo(2, 3);
            isPositive(4);
            posNumber(-12);
            TryVote(32);
            numRange(4);
            MultTable(5);
        }
    }
}
