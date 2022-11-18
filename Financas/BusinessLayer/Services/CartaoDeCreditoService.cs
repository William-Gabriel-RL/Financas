using BusinessLayer.DTO.CartaoDeCreditoDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using RepoLayer.Repos;

namespace BusinessLayer.Services
{
    public class CartaoDeCreditoService : ICartaoDeCreditoService
    {
        private readonly ICartaoDeCreditoRepo _cartaoDeCreditoRepo;
        public CartaoDeCreditoService()
        {
            _cartaoDeCreditoRepo = new CartaoDeCreditoRepo(new FinancasContext());
        }
        public void AtualizarCartao(AtualizarCartaoDeCreditoDTO cartaoDeCredito)
        {
            CartaoDeCredito cartao = new()
            {
                Id = cartaoDeCredito.Id,
                Bandeira = cartaoDeCredito.Bandeira,
                Emissor = cartaoDeCredito.Emissor,
                Vencimento = cartaoDeCredito.Vencimento,
                Fechamento = cartaoDeCredito.Fechamento,
                Limite = cartaoDeCredito.Limite,
                IdConta = cartaoDeCredito.IdConta,
            };
            _cartaoDeCreditoRepo.AtualizarCartao(cartao);
        }

        public void CriarCartao(BaseCartaoDeCreditoDTO cartaoDeCredito)
        {
            CartaoDeCredito cartao = new()
            {
                Bandeira = cartaoDeCredito.Bandeira,
                Emissor = cartaoDeCredito.Emissor,
                Vencimento = cartaoDeCredito.Vencimento,
                Fechamento = cartaoDeCredito.Fechamento,
                Limite = cartaoDeCredito.Limite,
                IdConta = cartaoDeCredito.IdConta,
            };
            _cartaoDeCreditoRepo.CriarCartao(cartao);
        }

        public void DeletarCartao(int id)
        {
            _cartaoDeCreditoRepo.DeletarCartao(id);
        }

        public CartaoDeCredito? ObterCartao(int id)
        {
            return _cartaoDeCreditoRepo.ObterCartao(id);
        }

        public IEnumerable<CartaoDeCredito> ObterCartaoPorConta(int idConta)
        {
            return _cartaoDeCreditoRepo.ObterCartaoPorConta(idConta);
        }
    }
}
