using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //Muul juhul kuvatakse konsoolis "vale kasutajatunnus või salasõna. Proovi uuesti."
            //Kasutajal on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;

                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti. Sul on {3 - i} katset jäänud.");
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");

                    break;
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
