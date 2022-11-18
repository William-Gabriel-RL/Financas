using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IContaRepo
    {
        public void CriarConta(Conta conta);
        public Conta? ObterConta(int id);
        public IEnumerable<Conta> ObterContasPorUsuario(int idUsuario);
        public void AtualizarConta(Conta conta);
        public void DeletarConta(int id);
    }
}
