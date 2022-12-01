using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface ICreditCardRepo
    {
        public void CreateCard(CreditCard creditCard);
        public CreditCard? ReadCard(int id);
        public IEnumerable<CreditCard> ReadCardsByAccount(int idAccount);
        public void UpdateCard(CreditCard creditCard);
        public void DeleteCard(int id);
    }
}
