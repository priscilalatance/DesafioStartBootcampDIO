using System;
using static System.Console;

namespace ExercicioTESTE5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = ReadLine().Split(' ');
            int A = int.Parse(number[0]), B = int.Parse(number[1]), C = int.Parse(number[2]),  D = int.Parse(number[3]);
      
            if((B > C) && (D > A) && ((C + D) > (A + B)) && (C > 0) && (D > 0) && ( A % 2 == 0)){
                WriteLine("Valores aceitos");
            }
            else{
                WriteLine("Valores nao aceitos");
            }
        }
    }
}
