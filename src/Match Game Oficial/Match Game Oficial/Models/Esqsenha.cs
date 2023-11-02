using System.ComponentModel.DataAnnotations;

namespace Match_Game_Oficial.Models
{
	public class Esqsenha
	{
		[Required]
		[EmailAddress]
		[Key]
		public string Email { get; set; }
		public string Codigo { get; set; }
		public string NovaSenha { get; set; }
	

    }
}


