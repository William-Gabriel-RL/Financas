using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using RepoLayer.Repos;

namespace BusinessLayer.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepo _usuarioRepo;
        public UsuarioService()
        {
            _usuarioRepo = new UsuarioRepo(new FinancasContext());
        }
        public void AtualizarUsuario(Usuario usuario)
        {
            _usuarioRepo.AtualizarUsuario(usuario);
        }

        public void CriarUsuario(Usuario usuario)
        {
            _usuarioRepo.CriarUsuario(usuario);
        }

        public void DeletarUsuario(int id)
        {
            _usuarioRepo.DeletarUsuario(id);
        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            return _usuarioRepo.ObterTodosUsuarios();
        }

        public Usuario? ObterUsuario(int id)
        {
            return _usuarioRepo.ObterUsuario(id);
        }
    }
}
