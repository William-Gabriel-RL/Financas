using BusinessLayer.DTO.ExpenseDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Interfaces;
using RepoLayer.Repos;
using RepoLayer.Context;

namespace BusinessLayer.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepo _expenseRepo;
        public ExpenseService()
        {
            _expenseRepo = new ExpenseRepo(new FinancasContext());
        }
        public void UpdateExpense(UpdateExpenseDTO expense)
        {
            Expense updatedExpense = new()
            {
                Id = expense.Id,
                Description = expense.Description,
                Amount = expense.Amount,
                PayDay = expense.PayDay,
                Category = expense.Category,
                Photo = expense.Photo,
                IdAccount = expense.IdAccount,
                Paid = expense.Paid,
                DueDate = expense.DueDate,
                IdCreditCard = expense.IdCreditCard,
            };
            _expenseRepo.UpdateExpense(updatedExpense);
        }

        public void CreateExpense(CreateExpenseDTO expense)
        {
            Expense createdExpense = new()
            {
                Description = expense.Description,
                Amount = expense.Amount,
                PayDay = expense.PayDay,
                Category = expense.Category,
                Photo = expense.Photo,
                IdAccount = expense.IdAccount,
                Paid = expense.Paid,
                DueDate = expense.DueDate,
                IdCreditCard = expense.IdCreditCard,
            };
            _expenseRepo.CreateExpense(createdExpense);
        }

        public void DeleteExpense(int id)
        {
            _expenseRepo.DeleteExpense(id);
        }

        public Expense? ReadExpense(int id)
        {
            return _expenseRepo.ReadExpense(id);
        }

        public IEnumerable<Expense> ReadExpensesByAccount(int idAccount)
        {
            return _expenseRepo.ReadExpenseByAccount(idAccount);
        }
    }
}
