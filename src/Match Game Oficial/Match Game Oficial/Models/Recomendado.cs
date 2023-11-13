using System.ComponentModel.DataAnnotations;

namespace Match_Game_Oficial.Models
{
    public class Recomendado
    {

        [Required]
        [Display(Name = "A partir de qual ano você tem interesse?")]
        public int AnoInicial { get; set; }

        [Required]
        [Display(Name = "Até qual ano você tem interesse?")]
        public int AnoFinal { get; set; }

        [Required]
        [Display(Name = "Selecione a plataforma de interesse")]
        public Form_Plat Plataforma { get; set; }

        [Required]
        [Display(Name = "Selecione o gênero de interesse")]
        public Form_Gen Genero { get; set; }
    }

    public enum Form_Plat
    {
        IOS = 4,
        Playstations = 2,
        Xbox = 3,
        Computador = 1,
        Android = 8,
        Linux = 6,
        Nintendo = 7,
        Atari = 9,
        Comodore = 10,
        Sega = 11,
        Web = 14,
    }

    public enum Form_Gen
    {
        Ação = 1,
        Indie = 2,
        Aventura = 3,
        Rpg = 4,
        Estratégia = 5,
        Shooter = 6,
        Casual = 7,
        Simulação = 8,
        Puzzle = 9,
        Arcade = 10,
        Plataformer = 11,
        Multiplayer = 12,
        Race = 13,
        Sports = 14,
        Fight = 15,
        Family = 16,
        BoardGames = 17,
        Educational = 18,
        Card = 19
    }

}


