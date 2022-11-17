using EntityLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUsuarioService
    {
        public void CriarUsuario(Usuario usuario);
        public Usuario? ObterUsuario(int id);
        public IEnumerable<Usuario> ObterTodosUsuarios();
        public void AtualizarUsuario(Usuario usuario);
        public void DeletarUsuario(int id);
    }
}
