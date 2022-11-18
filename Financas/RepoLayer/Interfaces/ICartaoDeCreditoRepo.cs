using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface ICartaoDeCreditoRepo
    {
        public void CriarCartao(CartaoDeCredito cartaoDeCredito);
        public CartaoDeCredito? ObterCartao(int id);
        public IEnumerable<CartaoDeCredito> ObterCartaoPorConta(int idConta);
        public void AtualizarCartao(CartaoDeCredito cartaoDeCredito);
        public void DeletarCartao(int id);
    }
}
