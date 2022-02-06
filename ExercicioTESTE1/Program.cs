using System;
using static System.Console;

namespace ExercicioTESTE1
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            int D = int.Parse(ReadLine());

            WriteLine($"DIFERENCA = {A * B - C * D}");
            ReadKey();       
        }
    }
}
