using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projetojogos.Domains
{
        [Table("Usuarios")]
        [Index(nameof(Nickname), IsUnique = true)]
        public class Usuarios
        {
            //Preencher os atributos 
            [Key]
            public Guid UsuarioID { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
            public string? Nome { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "O nickname do jogo é obrigatório!")]
            public string? Nickname { get; set; }
            public Guid JogoFavorito { get; set; }

            [ForeignKey("JogoFavorito")]
            public Jogos? Jogo { get; set; }

        }
    }


