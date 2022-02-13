using System;
using static System.Console;
using DramaSeries.Classes;

namespace DramaSeries
{
    class Program
    {
        static  SerieRepositorio repositorio = new SerieRepositorio();
        static  MovieRepositorio repositorioFilme = new MovieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                    break;
                    case "2":
                        InserirSerie();
                    break;
                    case "3":
                        AtualizarSerie();
                    break;
                    case "4":
                        ExcluirSerie();
                    break;
                    case "5":
                        VisualizarSerie();
                    break;
                    case "6":
                        ListarFilmes();
                    break;
                    case "7":
                        InserirFilme();
                    break;
                    case "8":
                        AtualizarFilme();
                    break;
                    case "9":
                        ExcluirFilme();
                    break;
                    case "10":
                        VisualizarFilme();
                    break;
                    case "C":
                        Clear();
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            WriteLine("Obrigado por utilizar nossos serviços.");
            ReadLine();
        }
        private static void ListarSeries()
        {
            WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()} {(excluido ? "*Excluído*" : "")}.");
            }
        }
        private static  void InserirSerie()
        {
            WriteLine("Inserir nova série");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(ReadLine());

			Write("Digite o Título da Série: ");
			string entradaTitulo = ReadLine();

			Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(ReadLine());

			Write("Digite a Descrição da Série: ");
			string entradaDescricao = ReadLine();            
            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Inserir(novaSerie);		
        }        
        private static void AtualizarSerie()
		{
			Write("Digite o id da série: ");
			int indiceSerie = int.Parse(ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(ReadLine());

			Write("Digite o Título da Série: ");
			string entradaTitulo = ReadLine();

			Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(ReadLine());

			Write("Digite a Descrição da Série: ");
			string entradaDescricao = ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie, 
                                            genero: (Genero)entradaGenero,
										    titulo: entradaTitulo, 
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
			repositorio.Atualizar(indiceSerie, atualizaSerie);
		}
        private static void ExcluirSerie()
		{
			Write("Digite o id da série: ");
			int indiceSerie = int.Parse(ReadLine());
			repositorio.Excluir(indiceSerie);
		}

        private static void VisualizarSerie()
		{
			Write("Digite o id da série: ");
			int indiceSerie = int.Parse(ReadLine());
			var serie = repositorio.RetornaPorId(indiceSerie);
			WriteLine(serie);
		}
        private static void ListarFilmes()
        {
            WriteLine("Listar filmes");
            var lista = repositorioFilme.Lista();

            if(lista.Count == 0)
            {
                WriteLine("Nenhum filme cadastrado.");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluidoFilme();
                WriteLine($"#ID {filme.retornaIdFilme()}: - {filme.retornaTituloFilme()} {(excluido ? "*Excluído*" : "")}.");
            }
        }
        private static void InserirFilme()
        {
            WriteLine("Inserir novo filme");
            foreach (int number in Enum.GetValues(typeof(Genero)))
            {
                WriteLine($"{number}-{Enum.GetName(typeof(Genero), number)}");
            }
            Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(ReadLine());

			Write("Digite o Título do Filme: ");
			string entradaTitulo = ReadLine();

			Write("Digite o Ano de Lançamento: ");
			int entradaAno = int.Parse(ReadLine());

			Write("Digite a Descrição da Série: ");
			string entradaDescricao = ReadLine();

            Movies novoFilme = new Movies(id: repositorioFilme.ProximoId(), 
                                            genero: (Genero)entradaGenero,
										    titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
            repositorioFilme.Inserir(novoFilme);		
        }
        private static void AtualizarFilme()
		{
			Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(ReadLine());
			foreach (int number in Enum.GetValues(typeof(Genero)))
			{
				WriteLine("{0}-{1}", number, Enum.GetName(typeof(Genero), number));
			}
			Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(ReadLine());

			Write("Digite o Título do Filme: ");
			string entradaTitulo = ReadLine();

			Write("Digite o Ano de Lançamento: ");
			int entradaAno = int.Parse(ReadLine());

			Write("Digite a Descrição do Filme: ");
			string entradaDescricao = ReadLine();

			Movies atualizaFilme = new Movies(id: indiceFilme, 
                                                genero: (Genero)entradaGenero,
										        titulo: entradaTitulo, 
                                                ano: entradaAno, 
                                                descricao: entradaDescricao);
			repositorioFilme.Atualizar(indiceFilme, atualizaFilme);
		}
        private static void ExcluirFilme()
		{
			Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(ReadLine());
			repositorioFilme.Excluir(indiceFilme);
		}
        private static void VisualizarFilme()
		{
			Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(ReadLine());
			var filme = repositorioFilme.RetornaPorId(indiceFilme);
			WriteLine(filme);
		}
        private static string ObterOpcaoUsuario()
        {
            WriteLine("\nBem vindo ao DoramaFlix! A sua melhor escolha para Doramas Asiáticos!\nInforme a opção desejada:\n");
            WriteLine("1- Listar séries.\n2- Inserir nova série.\n3- Atualizar série.");
            WriteLine("4- Excluir série.\n5- Visualizar série.\n6- Listar Filmes.");
            WriteLine("7- Inserir novo filme.\n8- Atualizar filme.\n9- Excluir Filme.\n10- Visualizar filme.");
            WriteLine("C- Limpar Tela.\nX- Sair.");            
            string opcaoUsuario = ReadLine().ToUpper();
            WriteLine();
            return opcaoUsuario;
        }
    }
}
