using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IReceitaRepo
    {
        public void CriarReceita(Receita receita);
        public Receita? ObterReceita(int id);
        public IEnumerable<Receita> ObterReceitaPorConta(int idConta);
        public void AtualizarReceita(Receita receita);
        public void DeletarReceita(int id);
    }
}
