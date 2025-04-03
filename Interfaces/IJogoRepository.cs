using Projetojogos.Domains;

namespace Projetojogos.Interfaces
{
    public interface IJogoRepository
    {
        void cadastrar(Jogos jogoNovo);

        void deletar(Jogos jogos);

        void atualizar(Guid idDojogo, Jogos jogoAtualizado);

        List<Jogos> Listar();
    }
}
