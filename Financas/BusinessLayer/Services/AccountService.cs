using BusinessLayer.DTO.AccountDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using RepoLayer.Repos;

namespace BusinessLayer.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepo _accountRepo;
        public AccountService()
        {
            _accountRepo = new AccountRepo(new FinancasContext());
        }
        public void UpdateAccount(UpdateAccountDTO account)
        {
            Account modifiedAccount = new()
            {
                Id = account.Id,
                Name = account.Name,
                Bank = account.Bank,
                Type = account.Type,
                IdUser = account.IdUser,
            };
            _accountRepo.UpdateAccount(modifiedAccount);
        }

        public void CreateAccount(BaseAccountDTO account)
        {
            Account newAccount = new()
            {
                Name = account.Name,
                Bank = account.Bank,
                Type = account.Type,
                IdUser = account.IdUser,
            };
            _accountRepo.CreateAccount(newAccount);
        }

        public void DeleteAccount(int id)
        {
            _accountRepo.DeleteAccount(id);
        }

        public Account? ReadAccount(int id)
        {
            if (id != 0)
            {
                return _accountRepo.ReadAccount(id);
            }
            return null;
        }

        public IEnumerable<Account> ReadAccountsByUser(int idUser)
        {
            return _accountRepo.ReadAccountsByUser(idUser);
        }
    }
}
