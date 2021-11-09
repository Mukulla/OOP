using System;

namespace OOP005
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
        }

        static void Execute()
        {
            int SomeValue = 3;
            Fractus First = new Fractus(1, 3);
            Fractus Second = new Fractus(7, 13);
            Fractus Tertius = new Fractus(11, 31);

            Console.WriteLine($"Increment = {++First}");
            Console.WriteLine($"Decrement = {--Second}");

            Console.WriteLine($"Summ {First} + {Second} = {First + Second}");
            Console.WriteLine($"Summ {First} - {Second} = {First - Second}");
            Console.WriteLine($"Summ {First} * {Second} = {First * Second}");
            Console.WriteLine($"Summ {First} / {Second} = {First / Second}");

            Console.WriteLine($"Summ {First} == {Second} = {First == Second}");
            Console.WriteLine($"Summ {First} != {Second} = {First != Second}");
            Console.WriteLine($"Summ {First} > {Second} = {First > Second}");
            Console.WriteLine($"Summ {First} < {Second} = {First < Second}");
            Console.WriteLine($"Summ {First} >= {Second} = {First >= Second}");
            Console.WriteLine($"Summ {First} <= {Second} = {First <= Second}");


            Console.WriteLine($"Summ {First} + {SomeValue} = {First + SomeValue}");
            Console.WriteLine($"Summ {First} - {SomeValue} = {First - SomeValue}");
            Console.WriteLine($"Summ {First} * {SomeValue} = {First * SomeValue}");
            Console.WriteLine($"Summ {First} / {SomeValue} = {First / SomeValue}");

            Console.WriteLine($"Summ {First} == {SomeValue} = {First == SomeValue}");
            Console.WriteLine($"Summ {First} != {SomeValue} = {First != SomeValue}");
            Console.WriteLine($"Summ {First} > {SomeValue} = {First > SomeValue}");
            Console.WriteLine($"Summ {First} < {SomeValue} = {First < SomeValue}");
            Console.WriteLine($"Summ {First} >= {SomeValue} = {First >= SomeValue}");
            Console.WriteLine($"Summ {First} <= {SomeValue} = {First <= SomeValue}");

            Console.WriteLine($"{First} + {Second} / {Tertius} - {SomeValue} = {First + Second / Tertius - SomeValue} ");
           
            Console.ReadKey();
        }
    }
}
