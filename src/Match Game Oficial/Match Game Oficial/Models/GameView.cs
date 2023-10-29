using System.ComponentModel.DataAnnotations;

namespace Match_Game_Oficial.Models
{
    public class GameView
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Storyline { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset? FirstReleaseDate { get; set; }

    }
}
