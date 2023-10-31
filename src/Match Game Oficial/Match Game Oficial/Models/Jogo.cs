using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Match_Game_Oficial.Models
{
    public class Jogo
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "Orçamento")]
        public Orcamento Orcamento { get; set; }

        [Display(Name = "Plataforma")]
        public Plataforma Plataforma { get; set; }

        [Display(Name = "Modo de Jogo: ")]
        public ModoJogo MododeJogo { get; set; }

    }

    public enum ModoJogo
    {
        Multiplayer,
        Singleplayer
    }

    public enum Plataforma
    {
        Console,
        Mobile,
        Computador
    }

    public enum Orcamento
    {
        [Display(Name = "Até $50")]
        Ate50 = 1,

        [Display(Name = "Até $100")]
        Ate100 = 2,

        [Display(Name = "Até $250")]
        Ate250 = 3,

        [Display(Name = "Acima de $250")]
        Acima250 = 4,

        [Display(Name = "Gratuito")]
        Gratuito = 5
    }
}


