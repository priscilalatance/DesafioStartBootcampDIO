using System;
using static System.Console;

namespace ExercicioTESTE6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, finalAverage;
            string[] grades = ReadLine().Split(' ');
      
            a = double.Parse(grades[0]);
            b = double.Parse(grades[1]);
            c = double.Parse(grades[2]);
            d = double.Parse(grades[3]);
      
            finalAverage = (a * 2 + b * 3 + c * 4 + d * 1) / 10;
            WriteLine("Media: " + finalAverage.ToString("0.0"));
      
            if (finalAverage >= 7) 
            {
            WriteLine("Aluno aprovado.");
             } else if (finalAverage < 5) 
            {
            WriteLine("Aluno reprovado.");
            } else if (finalAverage <= 6.9){
            double examination = double.Parse(ReadLine());
        
            WriteLine("Aluno em exame.");
            WriteLine("Nota do exame: " + examination.ToString("0.0"));
            finalAverage = (finalAverage + examination) / 2;
        
            if (finalAverage >= 5) {
                WriteLine("Aluno aprovado.");
            } else {
            WriteLine("Aluno reprovado");
            }
            WriteLine("Media final: " + finalAverage.ToString("0.0"));
            }
        }
    }
}
