using EntityLayer.Models;

namespace RepoLayer.Interfaces
{
    public interface IUsuarioRepo
    {
        public void CriarUsuario(Usuario usuario);
        public Usuario? ObterUsuario(int id);
        public IEnumerable<Usuario> ObterTodosUsuarios();
        public void AtualizarUsuario(Usuario usuario);
        public void DeletarUsuario(int id);
    }
}
