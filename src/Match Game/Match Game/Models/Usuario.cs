using System.ComponentModel.DataAnnotations;

namespace Match_Game.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="Obrigatório informar o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento.")]
        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public int ID_User { get; set; }

        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }

}
