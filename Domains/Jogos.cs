//Caminho em que a classe jogo esta 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projetojogos.Domains
{
    [Table("Jogos")] 
    //O index faz com que o nome do jogo nao se repita
    [Index(nameof(nomeDojogo), IsUnique = true)]
    //Public class -> Cria uma classe publica 
    public class Jogos
    {
        //Preencher atributos 
        [Key]
        public Guid jogoID {  get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        //O required faz com que seja obrigatorio preencher o campo NomeDoJogo
        [Required(ErrorMessage = "O nome do jogo e obrigatorio")]
        public string? nomeDojogo {  get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }   
    }
}
