using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class ExpenseRepo : IExpenseRepo
    {
        private readonly FinancasContext _context;
        public ExpenseRepo(FinancasContext context)
        {
            _context = context;
        }

        public void UpdateExpense(Expense expense)
        {
            _context.Entry(expense).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
        }

        public void DeleteExpense(int id)
        {
            Expense? expense = _context.Expenses.Find(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges();
            }
        }

        public Expense? ReadExpense(int id)
        {
            return _context.Expenses.Find(id);
        }

        public IEnumerable<Expense> ReadExpenseByAccount(int idAccount)
        {
            return _context.Expenses.Where(x => x.IdAccount == idAccount).ToList();
        }
    }
}
