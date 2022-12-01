using BusinessLayer.DTO.CreditCardDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using RepoLayer.Repos;

namespace BusinessLayer.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly ICreditCardRepo _creditCardRepo;
        public CreditCardService()
        {
            _creditCardRepo = new CreditCardRepo(new FinancasContext());
        }
        public void UpdateCard(UpdateCreditCardDTO creditCard)
        {
            CreditCard updatedCard = new()
            {
                Id = creditCard.Id,
                Flag = creditCard.Flag,
                Issuer = creditCard.Issuer,
                DueDate = creditCard.DueDate,
                Closure = creditCard.Closure,
                Limit = creditCard.Limit,
                IdAccount = creditCard.IdAccount,
            };
            _creditCardRepo.UpdateCard(updatedCard);
        }

        public void CreateCard(BaseCreditCardDTO creditCard)
        {
            CreditCard newCard = new()
            {
                Flag = creditCard.Flag,
                Issuer = creditCard.Issuer,
                DueDate = creditCard.DueDate,
                Closure = creditCard.Closure,
                Limit = creditCard.Limit,
                IdAccount = creditCard.IdAccount,
            };
            _creditCardRepo.CreateCard(newCard);
        }

        public void DeleteCard(int id)
        {
            _creditCardRepo.DeleteCard(id);
        }

        public CreditCard? ReadCard(int id)
        {
            return _creditCardRepo.ReadCard(id);
        }

        public IEnumerable<CreditCard> ReadCardsByAccount(int idAccount)
        {
            return _creditCardRepo.ReadCardsByAccount(idAccount);
        }
    }
}
