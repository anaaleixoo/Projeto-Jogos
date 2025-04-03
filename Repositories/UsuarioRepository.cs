using Projeto_Jogos.Context;
using Projetojogos.Domains;
using Projetojogos.Interfaces;

namespace Projetojogos.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ProjetoJogosContext _context;
        public UsuarioRepository(ProjetoJogosContext context)
        {
            _context = context;
        }
        public void atualizar(Guid idDoUsuario, Usuarios usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public void cadastrar(Jogo jogoNovo)
        {
            try
            {
                //Tentar cadastrar:
                jogoNovo.jogoID = Guid.NewGuid();

                _context.Jogo.Add(jogoNovo);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            {

        }

        public void deletar(Guid IdDousuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
