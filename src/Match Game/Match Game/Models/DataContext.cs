using Microsoft.EntityFrameworkCore;

namespace Match_Game.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }

        //Criando o BD
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Jogo> Jogos { get; set;}

        public DbSet<Genero> Generos { get; set; }

        public DbSet<Usuario> Permissao { get; set; }

        //Definindo Chaves primárias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(u => u.ID_User);
            modelBuilder.Entity<Jogo>().HasKey(j => j.ID_Jogo);
            modelBuilder.Entity<Genero>().HasKey(g => g.ID_Genero);
        }
    }
}
