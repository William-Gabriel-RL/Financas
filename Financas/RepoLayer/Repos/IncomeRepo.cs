using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class IncomeRepo : IIncomeRepo
    {
        private readonly FinancasContext _context;
        public IncomeRepo(FinancasContext context)
        {
            _context = context; 
        }

        public void UpdateIncome(Income income)
        {
            _context.Entry(income).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateIncome(Income income)
        {
            _context.Incomes.Add(income);
            _context.SaveChanges();
        }

        public void DeleteIncome(int id)
        {
            Income? income = _context.Incomes.Find(id);
            if (income != null)
            {
                _context.Incomes.Remove(income);
                _context.SaveChanges();
            }
        }

        public Income? ReadIncome(int id)
        {
            return _context.Incomes.Find(id);
        }

        public IEnumerable<Income> ReadIncomesByAccount(int idAccount)
        {
            return _context.Incomes.Where(x => x.IdAccount == idAccount).ToList();
        }
    }
}
