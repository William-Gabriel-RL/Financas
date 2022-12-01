using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IIncomeRepo
    {
        public void CreateIncome(Income receita);
        public Income? ReadIncome(int id);
        public IEnumerable<Income> ReadIncomesByAccount(int idConta);
        public void UpdateIncome(Income receita);
        public void DeleteIncome(int id);
    }
}
