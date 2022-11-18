using BusinessLayer.DTO.ReceitaDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IReceitaService
    {
        public void CriarReceita(CriarReceitaDTO receita);
        public Receita? ObterReceita(int id);
        public IEnumerable<Receita> ObterReceitaPorConta(int idConta);
        public void AtualizarReceita(AtualizarReceitaDTO receita);
        public void DeletarReceita(int id);
    }
}
