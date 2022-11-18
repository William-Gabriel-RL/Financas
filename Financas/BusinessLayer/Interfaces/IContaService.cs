using BusinessLayer.DTO.ContaDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IContaService
    {
        public void CriarConta(BaseContaDTO conta);
        public Conta? ObterConta(int id);
        public IEnumerable<Conta> ObterContasPorUsuario(int idUsuario);
        public void AtualizarConta(AtualizarContaDTO conta);
        public void DeletarConta(int id);
    }
}
