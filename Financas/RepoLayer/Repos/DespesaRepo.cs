using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class DespesaRepo : IDespesaRepo
    {
        private readonly FinancasContext _context;
        public DespesaRepo(FinancasContext context)
        {
            _context = context;
        }

        public void AtualizarDespesa(Despesa despesa)
        {
            _context.Entry(despesa).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarDespesa(Despesa despesa)
        {
            _context.Despesas.Add(despesa);
            _context.SaveChanges();
        }

        public void DeletarDespesa(int id)
        {
            Despesa? despesa = _context.Despesas.Find(id);
            if (despesa != null)
            {
                _context.Despesas.Remove(despesa);
                _context.SaveChanges();
            }
        }

        public Despesa? ObterDespesa(int id)
        {
            return _context.Despesas.Find(id);
        }

        public IEnumerable<Despesa> ObterDespesaPorConta(int idConta)
        {
            return _context.Despesas.Where(x => x.IdConta == idConta).ToList();
        }
    }
}
