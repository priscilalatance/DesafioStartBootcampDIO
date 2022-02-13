namespace DramaSeries
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public int IdFilme { get; protected set; } 
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }     
    }
}