using Projeto_Jogos.Context;
using Projetojogos.Domains;
using Projetojogos.Interfaces;

namespace Projetojogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly ProjetoJogosContext _context;
        public JogoRepository(ProjetoJogosContext context)
        {
            _context = context;
        }
        public void atualizar(Guid idDojogo, Jogos jogoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void cadastrar(Jogos jogoNovo)
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
            


        public void deletar(Jogos jogos)
        {
            throw new NotImplementedException();
        }

        public List<Jogos> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
