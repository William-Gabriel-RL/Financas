using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IExpenseRepo
    {
        public void CreateExpense(Expense despesa);
        public Expense? ReadExpense(int id);
        public IEnumerable<Expense> ReadExpenseByAccount(int idAccount);
        public void UpdateExpense(Expense despesa);
        public void DeleteExpense(int id);
    }
}
