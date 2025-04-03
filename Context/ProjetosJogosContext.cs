using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Projetojogos.Domains;

namespace Projeto_Jogos.Context
{
    public class ProjetoJogosContext : DbContext
    {
        //Metodo construtor tem o mesmo nome da classe
        public ProjetoJogosContext() { }

        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options) : base(options)
        {

        }
        //Cria a tabela de jogos
        public DbSet<Jogos> Jogo { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE02-S28\\SQLEXPRESS; Database=projetojogos; User Id = sa; Pwd=Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}