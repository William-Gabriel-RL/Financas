using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IDespesaRepo
    {
        public void CriarDespesa(Despesa despesa);
        public Despesa? ObterDespesa(int id);
        public IEnumerable<Despesa> ObterDespesaPorConta(int idConta);
        public void AtualizarDespesa(Despesa despesa);
        public void DeletarDespesa(int id);
    }
}
