using BusinessLayer.DTO.AccountDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IAccountService
    {
        public void CreateAccount(BaseAccountDTO account);
        public Account? ReadAccount(int id);
        public IEnumerable<Account> ReadAccountsByUser(int idUser);
        public void UpdateAccount(UpdateAccountDTO account);
        public void DeleteAccount(int id);
    }
}
