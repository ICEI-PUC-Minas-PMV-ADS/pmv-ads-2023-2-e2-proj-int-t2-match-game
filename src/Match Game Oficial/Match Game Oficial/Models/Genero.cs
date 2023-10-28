using System.ComponentModel.DataAnnotations;

namespace Match_Game_Oficial.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Nome_Genero { get; set; }
    }
}
