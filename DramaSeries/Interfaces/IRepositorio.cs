using System.Collections.Generic;


namespace DramaSeries.Interfaces
{
    public interface IRepositorio<List>    
    {
        List<List> Lista();
        List RetornaPorId(int id);
        void Inserir(List entidade);
        void Excluir(int id);
        void Atualizar(int id, List entidade);
        int ProximoId();
    }
}