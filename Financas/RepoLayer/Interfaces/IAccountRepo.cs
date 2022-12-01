using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IAccountRepo
    {
        public void CreateAccount(Account conta);
        public Account? ReadAccount(int id);
        public IEnumerable<Account> ReadAccountsByUser(int idUser);
        public void UpdateAccount(Account account);
        public void DeleteAccount(int id);
    }
}
