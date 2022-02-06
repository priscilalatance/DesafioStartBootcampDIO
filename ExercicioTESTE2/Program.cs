using System;
using static System.Console;

namespace ExercicioTESTE2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = ReadLine().Split(' ');
            int A = int.Parse(number[0]);
            int B = int.Parse(number[1]);

            if (A % B == 0 || B % A == 0)
            {
                WriteLine($"Sao Multiplos");
            }
            else
            {
                WriteLine($"Nao sao Multiplos");
            }
        }
    }
}
