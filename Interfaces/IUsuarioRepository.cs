using Projetojogos.Domains;

namespace Projetojogos.Interfaces
{
    public interface IUsuarioRepository
    {
        void cadastrar(Usuarios usuarioNovo); 

        void deletar(Guid IdDousuario);

        void atualizar(Guid idDoUsuario, Usuarios usuarioAtualizado);

        List<Usuarios> Listar();
          

    }
}
