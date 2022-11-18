using BusinessLayer.DTO.CartaoDeCreditoDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface ICartaoDeCreditoService
    {
        public void CriarCartao(BaseCartaoDeCreditoDTO cartaoDeCredito);
        public CartaoDeCredito? ObterCartao(int id);
        public IEnumerable<CartaoDeCredito> ObterCartaoPorConta(int idConta);
        public void AtualizarCartao(AtualizarCartaoDeCreditoDTO cartaoDeCredito);
        public void DeletarCartao(int id);
    }
}
