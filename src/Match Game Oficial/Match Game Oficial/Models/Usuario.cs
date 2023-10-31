using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Match_Game_Oficial.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira o dado corretamente!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira o dado corretamente!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Insira o dado corretamente!")]
        public string Email { get; set; }

        [DataType(DataType.Date)] 
        public DateTime Data_Nascimento { get; set; }

        public byte[]? Foto {  get; set; }


    }
}
