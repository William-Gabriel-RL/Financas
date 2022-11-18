using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class ReceitaRepo : IReceitaRepo
    {
        private readonly FinancasContext _context;
        public ReceitaRepo(FinancasContext context)
        {
            _context = context; 
        }

        public void AtualizarReceita(Receita receita)
        {
            _context.Entry(receita).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarReceita(Receita receita)
        {
            _context.Receitas.Add(receita);
            _context.SaveChanges();
        }

        public void DeletarReceita(int id)
        {
            Receita? receita = _context.Receitas.Find(id);
            if (receita != null)
            {
                _context.Receitas.Remove(receita);
                _context.SaveChanges();
            }
        }

        public Receita? ObterReceita(int id)
        {
            return _context.Receitas.Find(id);
        }

        public IEnumerable<Receita> ObterReceitaPorConta(int idConta)
        {
            return _context.Receitas.Where(x => x.IdConta == idConta).ToList();
        }
    }
}
