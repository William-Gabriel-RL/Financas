using BusinessLayer.DTO.IncomeDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IIncomeService
    {
        public void CreateIncome(CreateIncomeDTO income);
        public Income? ReadIncome(int id);
        public IEnumerable<Income> ReadIncomesByAccount(int idAccount);
        public void UpdateIncome(UpdateIncomeDTO income);
        public void DeleteIncome(int id);
    }
}
