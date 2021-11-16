using System;

namespace OOP7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tempo = "формировании новых предложений 1924 in Monolith Studious";
            //string Tempo = "489156 18961 4564 8";
            ICodar CodarA = new ACoder();
            string Execute = CodarA.Encode(Tempo);

            Console.WriteLine($"Input: {Tempo}\nEncoded: {Execute}");
            Console.WriteLine($"Decoded: {CodarA.Decode(Execute)}");
            Console.WriteLine();



            ICodar CodarB = new BCoder();
            Execute = CodarB.Encode(Tempo);

            Console.WriteLine($"Input: {Tempo}\nEncoded: {Execute}");
            Console.WriteLine($"Decoded: {CodarB.Decode(Execute)}");
            Console.WriteLine();

            Console.WriteLine("Pres any key to exit");
            Console.ReadKey();
        }
    }
}
