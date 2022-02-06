using System;
using static System.Console;

namespace ExercicioTESTE4
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracter;
            int number;
      
            while((caracter = ReadLine()) != null)
            {
                if ((!int.TryParse(caracter, out number) || ( number < 0) || (number > 100)))
                     WriteLine("Dados invalidos, digite novamente!");                
                else if (number == 0)
                    WriteLine("vai ter copa!");
                else
                    WriteLine("vai ter duas!");
            }
        }
    }
}
