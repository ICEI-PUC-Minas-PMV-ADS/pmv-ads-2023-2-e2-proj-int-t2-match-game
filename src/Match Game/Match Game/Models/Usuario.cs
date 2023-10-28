using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Match_Game.Models
{
    public class Usuario
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_User { get; set; }

        public byte[]? FotoUsuario { get; set; }
    }
}
