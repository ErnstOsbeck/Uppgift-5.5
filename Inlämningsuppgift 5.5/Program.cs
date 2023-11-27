using System;

namespace uppgift_5._5
{
    class program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            string[] svar = { "Ja", "Nej", "Kanske", "Fråga igen senare", "Lagen kräver att jag inte svara på den frågan", "Det är ingen bra idé", "Du är en idiot", "Du vill inte veta svaret på den frågan", "Starkt recommenderat", "Prata med min advokat" };
            bool x = true;
            do
            {
                Console.WriteLine("Ställ en fråga eller skriv \"a\" för att avsluta.");
                string fråga = Console.ReadLine();
                if (fråga == "a")
                {
                    x = false;
                }
                else
                {
                    Console.WriteLine(svar[slump.Next(0, 9)]);
                }
            }
            while (x);
        }
    }
}
