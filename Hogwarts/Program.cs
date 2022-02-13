using System;
using Hogwarts.crc.Entities;

namespace Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {

            Harry opponentHarry = new Harry("Harry Potter", " Gryffindor's house", "Power");
            Hermione opponentHermione = new Hermione("Hermione Granger", "Ravenclaw's house", "Smart");
            Rony opponentRony = new Rony("Ronald Weasley", "Hufflepuff's house", "Peacemaker");
            Draco opponentDraco = new Draco("Draco Malfoy", "Slytherin's house", "Influencer");

            Console.WriteLine("Bem Vindo a Hogwarts!\n\nEscolha um dos quatros jogadores para vencer a guerra contra os seguidores daquele que não deve ser nomeado:\n1 - Harry Potter.\n2 - Hermione Granger.\n3 - Ronald Weasley.\n4 - Draco Malfoy.\n");
            
            int select = int.Parse(Console.ReadLine());
            
            switch(select)
            {
                case 1:
                    Console.WriteLine(opponentHarry.ToString());
                    Console.WriteLine(opponentHarry.Attack());
                break;
                case 2:
                    Console.WriteLine(opponentHermione.ToString());
                    Console.WriteLine(opponentHermione.Attack());
                break;
                case 3:
                    Console.WriteLine(opponentRony.ToString());
                    Console.WriteLine(opponentRony.Attack());
                break;
                case 4:
                    Console.WriteLine(opponentDraco.ToString());
                    Console.WriteLine(opponentDraco.Attack());
                break;

            }
        }
    }
}
