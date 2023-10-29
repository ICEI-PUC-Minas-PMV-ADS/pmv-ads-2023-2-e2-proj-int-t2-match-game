namespace Match_Game_Oficial.Models
{
    public class GameView
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Storyline { get; set; }

        public DateTimeOffset? FirstReleaseDate { get; set; }

    }
}
