using BusinessLayer.DTO.DespesaDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IDespesaService
    {
        public void CriarDespesa(CriarDespesaDTO despesa);
        public Despesa? ObterDespesa(int id);
        public IEnumerable<Despesa> ObterDespesaPorConta(int idConta);
        public void AtualizarDespesa(AtualizarDespesaDTO despesa);
        public void DeletarDespesa(int id);
    }
}
