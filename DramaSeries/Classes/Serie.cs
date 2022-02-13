namespace DramaSeries

{
    public class Serie : EntityBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
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
            dados += $"Ano de Início: {this.Ano}\n";
            dados += $"Série Excluída: {this.Excluido}\n";
            return dados;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() 
        {
            this.Excluido = true;
        }    
    }
}