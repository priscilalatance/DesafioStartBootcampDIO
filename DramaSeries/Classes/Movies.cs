using System;
using static System.Console;

namespace DramaSeries.Classes
{
    public class Movies : EntityBase
    {
        static MovieRepositorio repositorio = new MovieRepositorio();
        public Movies(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string dados = "";
            dados += $"Gênero: {this.Genero}\n";
            dados += $"Título: {this.Titulo}\n";
            dados += $"Descrição: {this.Descricao}\n";
            dados += $"Ano de Lançamento: {this.Ano}\n";            
            dados += $"Filme Excluído: {this.Excluido}\n";
            return dados;
        }
        public string retornaTituloFilme()
        {
            return this.Titulo;
        }
        public int retornaIdFilme()
        {
            return this.Id;
        }
        public bool retornaExcluidoFilme()
		{
			return this.Excluido;
		}
        public void ExcluirFilme() 
        {
            this.Excluido = true;
        }    
    }
}