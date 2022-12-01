using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class CreditCardRepo : ICreditCardRepo
    {
        private readonly FinancasContext _context;
        public CreditCardRepo(FinancasContext context)
        {
            _context = context;
        }

        public void UpdateCard(CreditCard creditCard)
        {
            _context.Entry(creditCard).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateCard(CreditCard creditCard)
        {
            _context.CreditCards.Add(creditCard);
            _context.SaveChanges();
        }

        public void DeleteCard(int id)
        {
            CreditCard? creditCard = _context.CreditCards.Find(id);
            if (creditCard != null)
            {
                _context.CreditCards.Remove(creditCard);
                _context.SaveChanges();
            }
        }

        public CreditCard? ReadCard(int id)
        {
            return _context.CreditCards.Find(id);
        }

        public IEnumerable<CreditCard> ReadCardsByAccount(int idAccount)
        {
            return _context.CreditCards
                .Where(x => x.IdAccount == idAccount)
                .ToList();
        }
    }
}
