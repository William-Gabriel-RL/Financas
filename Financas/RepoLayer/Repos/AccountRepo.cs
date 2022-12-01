using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class AccountRepo : IAccountRepo
    {
        private readonly FinancasContext _context;
        public AccountRepo(FinancasContext context)
        {
            _context = context;
        }

        public void UpdateAccount(Account account)
        {
            _context.Entry(account).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(int id)
        {
            Account? account = _context.Accounts.Find(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
        }

        public Account? ReadAccount(int id)
        {
            return _context.Accounts.Find(id);
        }

        public IEnumerable<Account> ReadAccountsByUser(int idUser)
        {
            return _context.Accounts
                .Where(x => x.IdUser == idUser)
                .ToList();
        }
    }
}
