namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Print1000();
            PrintBy3();
            EqualTest();
            EvenOdds();
            PosNegNum();
            VoterAge();
            InRangeNum();
            MultiplyTable(12);
        }


        static void Print1000()
        {

            for (int oldAge = 1000; oldAge >= -1000; oldAge--)

            {
                Console.WriteLine(oldAge);
            }
        }

        static void PrintBy3()

        {
            for (int i = 3; i <= 999; i += 3)

            {
                Console.WriteLine(i);
            }
        }


        static void EqualTest()
        {
            Console.WriteLine($"Equal to test! Enter a nunber");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number please.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} is equal to {secondNumber}.");

            }

            else
            {
                Console.WriteLine("The two numbers are not equal.");
            }

        }

            static void EvenOdds()
            {
                Console.WriteLine("Is your number even or odd? Enter a number to find out.");
                int evenOdd = Convert.ToInt32(Console.ReadLine());


                if (evenOdd % 2 == 0)
                {
                    Console.WriteLine($"{evenOdd} is an even number.");

                }
                else
                {
                    Console.WriteLine($"{evenOdd} is an odd number.");
                }
            }


        static void PosNegNum()
        {
            Console.WriteLine("This is a positive# negative# test. Please give a number.");
            int negPos = Convert.ToInt32(Console.ReadLine());

            if (negPos >= 0)
            {
                Console.WriteLine($"{negPos} is a posistive number");

            }

            else
            {
                Console.WriteLine($"{negPos} is a negative number");
            }

        }


        static void VoterAge()
        {
            Console.WriteLine("Please enter your age voter");
            var voterCandidateAge = Convert.ToInt32(Console.ReadLine());


            if (voterCandidateAge >= 18)
            {
                Console.WriteLine($"Age follows: {voterCandidateAge}.Voter meets the requirement to vote.");

            }

            else
            {

                Console.WriteLine($"Voter isn't eligible to vote.");

            }
        }


        static void InRangeNum()
        {
            Console.WriteLine("Where does your number land? Enter a number.");
            int mikesNumber = Convert.ToInt32(Console.ReadLine());

            if (mikesNumber >= -10 && mikesNumber <= 10)
            {
                Console.WriteLine($"The number {mikesNumber} landed in the zone.");


            }

            else
            {

                Console.WriteLine($"The number {mikesNumber} did not land in the zone.");
            }

        }

        static void MultiplyTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {num * i}");

            }


        }




























    }


}



            