using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IUserRepo
    {
        public void CreateUser(User user);
        public User? ReadUser(int id);
        public IEnumerable<User> ReadAllUsers();
        public void UpdateUser(User user);
        public void DeleteUser(int id);
    }
}
