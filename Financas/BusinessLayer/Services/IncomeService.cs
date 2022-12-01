using BusinessLayer.DTO.IncomeDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Interfaces;
using RepoLayer.Repos;
using RepoLayer.Context;

namespace BusinessLayer.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepo _incomeRepo;
        public IncomeService()
        {
            _incomeRepo = new IncomeRepo(new FinancasContext());
        }
        public void UpdateIncome(UpdateIncomeDTO income)
        {
            Income updatedIncome = new()
            {
                Id = income.Id,
                Description = income.Description,
                Amount = income.Amount,
                PayDay = income.PayDay,
                Category = income.Category,
                Photo = income.Photo,
                IdAccount = income.IdAccount,
                Received = income.Received,
            };
            _incomeRepo.UpdateIncome(updatedIncome);
        }

        public void CreateIncome(CreateIncomeDTO income)
        {
            Income createdIncome = new()
            {
                Description = income.Description,
                Amount = income.Amount,
                PayDay = income.PayDay,
                Category = income.Category,
                Photo = income.Photo,
                IdAccount = income.IdAccount,
                Received = income.Received,
            };
            _incomeRepo.CreateIncome(createdIncome);
        }

        public void DeleteIncome(int id)
        {
            _incomeRepo.DeleteIncome(id);
        }

        public Income? ReadIncome(int id)
        {
            return _incomeRepo.ReadIncome(id);
        }

        public IEnumerable<Income> ReadIncomesByAccount(int idAccount)
        {
            return _incomeRepo.ReadIncomesByAccount(idAccount);
        }
    }
}
