namespace övning_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Skapa en kod som gör att användaren mater in ett tal (int) och du ska få kolla om talet som användaren matar in är lika med det hemliga talet som du själv skriver in I din kod. T.ex 5.
Krav:

-Användaren vinnare om talet som skrevs är lika med talet vi har sparat I vår kod.

-Om användaren skriver ett tal som är högre än det talet vi har sparat I vår kod så ska användaren meddelas om det.

-Skulle användaren skriva ett tal som är lägre så ska användaren också få ett meddelande om det. */


            Console.WriteLine("Vällkommen till spelet");
            int Number = 5;
            

            while (true)
            {
                Console.WriteLine("gissa på siffran");
                int UserInput = int.Parse(Console.ReadLine());

                if (UserInput == Number)
                {
                    Console.WriteLine("Grattis du har gissat rätt");
                    break;
                }

                else if (UserInput > Number)
                {
                    Console.WriteLine("Numret du angav är hög");
                }

                else if (UserInput < Number)

                {
                    Console.WriteLine("Numret du angav är låg");
                }

                else

                {
                    Console.WriteLine("Hejdå");
                }
            }
        }
    }
}