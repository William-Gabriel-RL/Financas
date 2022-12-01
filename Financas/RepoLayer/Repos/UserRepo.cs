using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly FinancasContext _context;
        public UserRepo(FinancasContext context)
        {
            _context = context;
        }

        public void UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            User? user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> ReadAllUsers()
        {
            return _context.Users.ToList();
        }

        public User? ReadUser(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
