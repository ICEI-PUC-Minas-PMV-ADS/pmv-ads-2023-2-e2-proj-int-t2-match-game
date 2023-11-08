using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Match_Game_Oficial.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir a senha.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir o e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir a data de nascimento.")]
        [DataType(DataType.Date)] 
        public DateTime Data_Nascimento { get; set; }
       
        public byte[]? Foto {  get; set; }
        public Perfil Perfil { get; set; }

    }

    
    public enum Perfil
    {
        User,
        Admin
    }
    
}
