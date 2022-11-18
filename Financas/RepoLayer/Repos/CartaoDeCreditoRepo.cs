using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class CartaoDeCreditoRepo : ICartaoDeCreditoRepo
    {
        private readonly FinancasContext _context;
        public CartaoDeCreditoRepo(FinancasContext context)
        {
            _context = context;
        }

        public void AtualizarCartao(CartaoDeCredito cartaoDeCredito)
        {
            _context.Entry(cartaoDeCredito).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarCartao(CartaoDeCredito cartaoDeCredito)
        {
            _context.CartoesDeCredito.Add(cartaoDeCredito);
            _context.SaveChanges();
        }

        public void DeletarCartao(int id)
        {
            CartaoDeCredito? cartao = _context.CartoesDeCredito.Find(id);
            if (cartao != null)
            {
                _context.CartoesDeCredito.Remove(cartao);
                _context.SaveChanges();
            }
        }

        public CartaoDeCredito? ObterCartao(int id)
        {
            return _context.CartoesDeCredito.Find(id);
        }

        public IEnumerable<CartaoDeCredito> ObterCartaoPorConta(int idConta)
        {
            return _context.CartoesDeCredito
                .Where(x => x.IdConta == idConta)
                .ToList();
        }
    }
}
