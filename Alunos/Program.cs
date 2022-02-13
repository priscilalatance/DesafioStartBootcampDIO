using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Adicionar[] alunos = new Adicionar[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Adicionar();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da Nota deve ser decimal.");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        foreach(var listarAluno in alunos)
                        {
                            if(!string.IsNullOrEmpty(listarAluno.Nome))
                            {
                                Console.WriteLine($"Aluno: {listarAluno.Nome} - Nota: {listarAluno.Nota}.");
                            }
                        }

                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numeroAlunos = 0;

                        for (int i=0; i <alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numeroAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numeroAlunos;
                        ConceitoEnum conceitoGeral;

                        if ((mediaGeral < 4))
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if ((mediaGeral < 6))
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if ((mediaGeral < 8))
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if ((mediaGeral < 10))
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }
                        else
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }

                        Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();

            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
