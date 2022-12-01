using BusinessLayer.DTO.ExpenseDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IExpenseService
    {
        public void CreateExpense(CreateExpenseDTO expense);
        public Expense? ReadExpense(int id);
        public IEnumerable<Expense> ReadExpensesByAccount(int idAccount);
        public void UpdateExpense(UpdateExpenseDTO expense);
        public void DeleteExpense(int id);
    }
}
