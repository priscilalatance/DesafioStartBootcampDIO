using System;
using System.Collections.Generic;
using DramaSeries.Interfaces;

namespace DramaSeries.Classes
{
    public class MovieRepositorio : IRepositorio<Movies>
    {
        private List<Movies> listaFilme = new List<Movies>();
        public void Atualizar(int id, Movies objeto)
        {
           listaFilme[id] = objeto;
        }
        public void Excluir(int id)
        {
            listaFilme[id].ExcluirFilme();
        }
        public void Inserir(Movies objeto)
        {
            listaFilme.Add(objeto);
        }
        public List<Movies> Lista()
        {
            return listaFilme;
        }
        public int ProximoId()
        {
            return listaFilme.Count;
        }
        public Movies RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}
 