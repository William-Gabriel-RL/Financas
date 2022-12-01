using BusinessLayer.DTO.UserDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using RepoLayer.Repos;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _usuarioRepo;
        public UserService()
        {
            _usuarioRepo = new UserRepo(new FinancasContext());
        }
        public void UpdateUser(User user)
        {
            user.Password = EncryptPassword(user.Password);
            _usuarioRepo.UpdateUser(user);
        }

        public void CreateUser(CreateUserDTO user)
        {
            User newUser = new()
            {
                Name = user.Name,
                Email = user.Email,
                Password = EncryptPassword(user.Password),
            };
            _usuarioRepo.CreateUser(newUser);
        }

        public void DeleteUser(int id)
        {
            _usuarioRepo.DeleteUser(id);
        }

        public IEnumerable<User> ReadAllUsers()
        {
            return _usuarioRepo.ReadAllUsers();
        }

        public User? ReadUser(int id)
        {
            return _usuarioRepo.ReadUser(id);
        }

        public static string EncryptPassword(string password)
        {
            using var hash = SHA256.Create();
            var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(byteArray);
        }
    }
}
