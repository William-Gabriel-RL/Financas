using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RepoLayer.Repos
{
    public class UsuarioRepo : IUsuarioRepo
    {
        private readonly FinancasContext _context;
        public UsuarioRepo(FinancasContext context)
        {
            _context = context;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void DeletarUsuario(int id)
        {
            Usuario? usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario? ObterUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }
    }
}
