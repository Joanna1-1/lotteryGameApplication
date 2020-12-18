using System;

namespace LotteryGameApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessOne;
            int guessTwo;
            int guessThree;

            int randomOne;
            int randomTwo;
            int randomThree;

            int award;

            const int anyMatch = 10;
            const int twoMatch = 100;
            const int threeMatch_NoOrder = 1000;
            const int threeMatch_InOrder = 10000;
            const int noMatch = 0;

            Random ranNumberGenerator = new Random();
            randomOne = ranNumberGenerator.Next(1,5);
            randomTwo = ranNumberGenerator.Next(1, 5);
            randomThree = ranNumberGenerator.Next(1, 5);

            Console.WriteLine("Please guess your first number from 1 to 4: ");
            guessOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please guess your second number from 1 to 4: ");
            guessTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please guess your third number from 1 to 4: ");
            guessThree = Convert.ToInt32(Console.ReadLine());

            if (randomOne == guessOne && randomTwo == guessTwo && randomThree == guessThree)
            {
                award = threeMatch_InOrder;
            }
            else if((randomOne == guessOne && randomTwo == guessTwo)||(randomTwo == guessTwo && randomThree == guessThree)||(randomThree == guessThree && randomOne == guessOne))
            {
                award = twoMatch;
            }
            else if((randomOne == guessOne || randomTwo == guessOne || randomThree == guessOne) && (randomOne == guessTwo || randomTwo == guessTwo || randomThree == guessTwo) && (randomOne == guessThree||randomTwo == guessThree || randomThree == guessThree))
            {
                award = threeMatch_NoOrder;
            }
            else if (randomOne == guessOne || randomTwo == guessTwo || randomThree == guessThree)
            {
                award = anyMatch;
            }
            else
            {
                award = noMatch;
            }
            Console.WriteLine($"User guess numbers are: {guessOne},{guessTwo},{guessThree}");
            Console.WriteLine($"Random digit numbers are: {randomOne},{randomTwo},{randomThree}");
            Console.WriteLine($"You win {award:c0}!");

            Console.ReadKey();
        }
    }
}
