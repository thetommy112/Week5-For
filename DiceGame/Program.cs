using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat - arvuti(cpu) ja kasutaja (user);
            //Mõlemad viskavad täringuid;
            //Programm kontrollib, kumb mängija viskas rohkem;
            //Mängija, kes viskab rohkem, ongi võitja;
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine("Vajuta enterit, et visata!");
                Console.ReadLine();
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                
                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja saab punkti.");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti saab punkti.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Kumbki ei saa punkti.");
                }
            }


            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else
            {
                Console.WriteLine("Viik!");
            }


            Console.WriteLine("Kena päeva!");
        }
    }
}
