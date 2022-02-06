using System;
using static System.Console;

namespace ExercicioTESTE3
{
    class Program
    {
        static double LerDados()
        {
            string[] input = ReadLine().Split();
            int cod = int.Parse(input[0]);
            int numero = int.Parse(input[1]);
            double valor = double.Parse(input[2]);
        
            return numero * valor;
        }
    
        static void Main(string[] args)
        {
        
            double total =LerDados() + LerDados();
            WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
        }
    }
}
