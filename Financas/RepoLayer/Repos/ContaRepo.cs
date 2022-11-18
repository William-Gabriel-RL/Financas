using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class ContaRepo : IContaRepo
    {
        private readonly FinancasContext _context;
        public ContaRepo(FinancasContext context)
        {
            _context = context;
        }

        public void AtualizarConta(Conta conta)
        {
            _context.Entry(conta).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarConta(Conta conta)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();
        }

        public void DeletarConta(int id)
        {
            Conta? conta = _context.Contas.Find(id);
            if (conta != null)
            {
                _context.Contas.Remove(conta);
                _context.SaveChanges();
            }
        }

        public Conta? ObterConta(int id)
        {
            return _context.Contas.Find(id);
        }

        public IEnumerable<Conta> ObterContasPorUsuario(int idUsuario)
        {
            return _context.Contas
                .Where(x => x.IdUsuario == idUsuario)
                .ToList();
        }
    }
}
