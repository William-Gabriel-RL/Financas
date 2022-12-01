using BusinessLayer.DTO.CreditCardDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface ICreditCardService
    {
        public void CreateCard(BaseCreditCardDTO creditCard);
        public CreditCard? ReadCard(int id);
        public IEnumerable<CreditCard> ReadCardsByAccount(int idAccount);
        public void UpdateCard(UpdateCreditCardDTO creditCard);
        public void DeleteCard(int id);
    }
}
