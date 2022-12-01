using BusinessLayer.DTO.UserDTO;
using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUserService
    {
        public void CreateUser(CreateUserDTO usuario);
        public User? ReadUser(int id);
        public IEnumerable<User> ReadAllUsers();
        public void UpdateUser(User usuario);
        public void DeleteUser(int id);
    }
}
