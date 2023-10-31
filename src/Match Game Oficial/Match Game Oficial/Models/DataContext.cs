using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Match_Game_Oficial.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Genero> Generos { get; set; }

        public DbSet<GameView> Igdb {  get; set; } 
    } 

}
